using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace numerical_ode
{
    public partial class Form1 : Form
    {
        int ind_of_problem, num_of_nodes, num_of_subnodes, num_of_subsubnodes;
        PointPairList ans_nodes = new PointPairList();
        PointPairList ans_subnodes = new PointPairList();
        PointPairList ans_subsubnodes = new PointPairList();

        double eps, step, substep, subsubstep, err;
        const double pi = Math.PI;
        GraphPane pane;
        public Form1()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane;
            pane.Title.Text = "График интерполяции";
            pane.Title.FontSpec.Size = 16;
            pane.XAxis.Title.Text = "Ось X";
            pane.YAxis.Title.Text = "Ось Y";

            zedGraphControl.GraphPane.XAxis.MajorGrid.IsVisible = true;
            zedGraphControl.GraphPane.YAxis.MajorGrid.IsVisible = true;
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
        private double f(double t, double u)
        {
            switch (ind_of_problem)
            {
                case 0:
                    return 2.0 * Math.Sqrt(1.0 - u * u) / (eps*(2.0-t)*(2.0-t));
                default:
                    return 2.0 * Math.Sqrt(1.0 - u * u) / (eps * (2.0 - t) * (2.0 - t));
            }

        }
        private double exact_val(double t)
        {
            switch (ind_of_problem)
            {
                case 0:
                    return Math.Sin( t / (eps*(2.0-t)) );
                default:
                    return t*t;
            }

        }
        private void init_ans_nodes()
        {
            ans_nodes.Clear();
            ans_subnodes.Clear();
            ans_subsubnodes.Clear();

            step = 1.0 / (num_of_nodes - 1.0);
            substep = step / (num_of_subnodes + 1.0);
            subsubstep = substep / (num_of_subsubnodes + 1.0);

            double curT = 0, curU = 0;
            ans_nodes.Add(curT, curU);
            
            for (int i = 1; i < num_of_nodes; i++)
            {
                for (int j = 0; j < num_of_subnodes+1; j++)
                {
                    for (int k = 0; k < num_of_subsubnodes + 1; k++)
                    {
                        curT += subsubstep;
                        curU += subsubstep * f(curT, curU);
                        if(k!= num_of_subsubnodes) ans_subsubnodes.Add(curT, curU);
                    }
                    if (j != num_of_subnodes) ans_subnodes.Add(curT, curU);
                }
                ans_nodes.Add(curT, curU);
            }
        }

        private void calc()
        {
            double max_dev = 0;
            double max_val = 0;

            for(int i = 0; i < num_of_nodes; i++)
            {
                double dev = Math.Abs(ans_nodes[i].Y - exact_val(ans_nodes[i].X));
                if (dev > max_dev)
                    max_dev = dev;
                if (Math.Abs(ans_nodes[i].Y) > max_val)
                    max_val = Math.Abs(ans_nodes[i].Y);
            }
            
            err = 100.0 * max_dev / max_val;
        }
        private void draw_function()
        {
            PointPairList list = new PointPairList();
            double N = 10000;
            double stp = 1.0 / (N - 1), x = 0;
            for (int i = 0; i < N; i++)
            {
                list.Add(x, exact_val(x));
                x += stp;
            }
            LineItem myCurve = pane.AddCurve("Аналитическое решение", list, Color.Green, SymbolType.None);
            myCurve.Line.Width = 3.0F;
        }

        private void draw_ans_nodes()
        {
            if (!Hide1.Checked)
            {
                LineItem myCurve = pane.AddCurve("Численное решение", ans_nodes, Color.Blue, SymbolType.Circle);
                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(Color.Blue);
                myCurve.Symbol.Size = 5.0F;
                myCurve.Line.Width = 3.0F;
            }
            if (!Hide2.Checked)
            {
                LineItem myCurve1 = pane.AddCurve("Всомогательные узлы 1", ans_subnodes, Color.LightBlue, SymbolType.Circle);
                myCurve1.Line.IsVisible = false;
                myCurve1.Symbol.Fill = new Fill(Color.LightBlue);
                myCurve1.Symbol.Size = 4.5F;
                myCurve1.Line.Width = 3.0F;
            }
            if (!Hide3.Checked)
            {
                LineItem myCurve2 = pane.AddCurve("Всомогательные узлы 2", ans_subsubnodes, Color.Gray, SymbolType.Circle);
                myCurve2.Line.IsVisible = false;
                myCurve2.Symbol.Fill = new Fill(Color.Gray);
                myCurve2.Symbol.Size = 4.5F;
                myCurve2.Line.Width = 3.0F;
            }
        }
        private void draw()
        {
            pane.CurveList.Clear();
            draw_ans_nodes();
            draw_function();
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
        private void display_values()
        {
                error.Text = "Пошрешность: " + err.ToString("F5") + "%";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ind_of_problem = problem.SelectedIndex;
            num_of_nodes = Convert.ToInt32(number_of_nodes.Text);
            num_of_subnodes = Convert.ToInt32(number_of_subnodes.Text);
            num_of_subsubnodes = Convert.ToInt32(number_of_subsubnodes.Text);
            eps = Convert.ToDouble(Epsilon.Text);

            init_ans_nodes();
            calc();
            draw();
            display_values();
            //calc_table();
        }
        private void calc_table()
        {
            //grid.Rows.Clear();
            //grid.Columns.Clear();

            //grid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15);

            //if (ind_of_problem > 2)
            //    grid.Columns.Add("-1", "Таблица приближенных значений для F" + problem.Text);
            //else
            //    grid.Columns.Add("-1", "Таблица погрешностей для F" + problem.Text);

            //grid.Columns.Add("0", "");
            //grid.Columns.Add("1", "");
            //grid.Columns.Add("2", "");
            //grid.Columns.Add("3", "Количество узлов");
            //grid.Columns.Add("4", "");
            //grid.Columns.Add("5", "");
            //grid.Columns.Add("6", "");
            //grid.Rows.Add("", "", "5", "9", "17", "33", "65", "129");
            //grid.Rows.Add("", "Прямоугольники (слева)", "", "", "", "", "", "");
            //grid.Rows.Add("", "Прямоугольники (справа)", "", "", "", "", "", "");
            //grid.Rows.Add("Метод", "Прямоугольники (посередине)", "", "", "", "", "", "");
            //grid.Rows[3].Cells[0].Style.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            //grid.Rows.Add("", "Трапеции", "", "", "", "", "", "");
            //grid.Rows.Add("", "Симпсон", "", "", "", "", "", "");
            //grid.Columns["-1"].Width = 230;
            //grid.Columns["0"].Width = 300;
            //grid.Columns["1"].Width = 215;
            //grid.Columns["2"].Width = 215;
            //grid.Columns["3"].Width = 215;
            //grid.Columns["4"].Width = 215;
            //grid.Columns["5"].Width = 215;
            //grid.Columns["6"].Width = 215;

            //grid.Rows[0].Height = 30;
            //grid.Rows[1].Height = 30;
            //grid.Rows[2].Height = 30;
            //grid.Rows[3].Height = 30;
            //grid.Rows[4].Height = 30;
            //grid.Rows[5].Height = 30;

            //for (int column = 2; column <= 7; column++)
            //{
            //    for (int raw = 1; raw <= 5; raw++)
            //    {
            //        num_of_nodes = Convert.ToInt32(Math.Pow(2, column)) + 1;
            //        ind_of_method = raw - 1;
            //        init_nodes();
            //        calc();
            //        if (ind_of_problem > 2)
            //            grid[column, raw].Value = ans.ToString("F5");
            //        else
            //            grid[column, raw].Value = err.ToString("F5");
            //    }
            //}

            //num_of_nodes = Convert.ToInt32(number_of_nodes.Text);
            //ind_of_method = method.SelectedIndex;
            //init_nodes();
        }
    }
}
