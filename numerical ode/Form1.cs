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
        int ind_of_problem, num_of_nodes;
        double lambda, sigma;
        PointPairList ans_nodes1 = new PointPairList();
        PointPairList ans_nodes2 = new PointPairList();
        PointPairList ans_nodes3 = new PointPairList();

        double eps, step, err;
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
            ans_nodes1.Clear();
            ans_nodes2.Clear();
            ans_nodes3.Clear();
            
            { 
                step = 1.0 / (num_of_nodes - 1.0);

                double curT = 0, curU = 0;
                ans_nodes1.Add(curT, curU);

                for (int i = 1; i < num_of_nodes; i++)
                {
                    curU += step * f(curT, curU);
                    curT += step;
                    ans_nodes1.Add(curT, curU);
                }
            }

            {
                step = 1.0 / (num_of_nodes - 1.0);

                double curT = 0, curU = 0;
                ans_nodes2.Add(curT, curU);

                for (int i = 1; i < num_of_nodes; i++)
                {
                    double yh = curU + step*lambda*f(curT, curU);
                    curU += step * ((1.0-1.0/(2.0*lambda))*f(curT, curU) + (1.0 / (2.0 * lambda))*f(curT+step*lambda, yh));
                    curT += step;
                    ans_nodes2.Add(curT, curU);
                }
            }

            {
                step = 1.0 / (num_of_nodes - 1.0);

                double curT = 0, curU = 0;
                ans_nodes3.Add(curT, curU);

                for (int i = 1; i < num_of_nodes; i++)
                {
                    double yh1 = curU + 2.0 / 3.0 * step * lambda * f(curT, curU);
                    double yh2 = curU + 2.0 / 3.0 * step * ( (1.0 - 3.0 / (8.0 * sigma)) * f(curT, curU) + 3.0 / (8.0 * sigma) * f(curT+ 2.0 / 3.0 * step, yh1));
                    curU += step * (0.25*f(curT, curU) + (0.75-sigma)* f(curT + 2.0 / 3.0 * step, yh1) + sigma* f(curT + 2.0 / 3.0 * step, yh2));
                    curT += step;
                    ans_nodes3.Add(curT, curU);
                }
            }
        }

        private void calc()
        {
            double max_dev = 0;
            double max_val = 0;

            for(int i = 0; i < num_of_nodes; i++)
            {
                double dev = Math.Abs(ans_nodes1[i].Y - exact_val(ans_nodes1[i].X));
                if (dev > max_dev)
                    max_dev = dev;
                if (Math.Abs(ans_nodes1[i].Y) > max_val)
                    max_val = Math.Abs(ans_nodes1[i].Y);
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
            LineItem myCurve = pane.AddCurve("Аналитическое решение", list, Color.Blue, SymbolType.None);
            myCurve.Line.Width = 3.0F;
        }

        private void draw_ans_nodes()
        {
            if (!Hide1.Checked)
            {
                LineItem myCurve = pane.AddCurve("Односадийный метод", ans_nodes1, Color.Green, SymbolType.Circle);
                myCurve.Symbol.Fill = new Fill(Color.Green);
                myCurve.Symbol.Size = 5.0F;
                myCurve.Line.Width = 3.0F;
            }
            if (!Hide2.Checked)
            {
                LineItem myCurve1 = pane.AddCurve("Двустадийный метод", ans_nodes2, Color.Yellow, SymbolType.Circle);
                myCurve1.Symbol.Fill = new Fill(Color.Yellow);
                myCurve1.Symbol.Size = 4.5F;
                myCurve1.Line.Width = 3.0F;
            }
            if (!Hide3.Checked)
            {
                LineItem myCurve2 = pane.AddCurve("Трехстадийный метод", ans_nodes3, Color.Red, SymbolType.Circle);
                myCurve2.Symbol.Fill = new Fill(Color.Red);
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
            lambda = Convert.ToDouble(number_of_subnodes.Text);
            sigma = Convert.ToDouble(number_of_subsubnodes.Text);
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
