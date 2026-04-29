namespace numerical_ode
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.problem = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.number_of_nodes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Epsilon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.number_of_subnodes = new System.Windows.Forms.TextBox();
            this.number_of_subsubnodes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hide1 = new System.Windows.Forms.CheckBox();
            this.Hide2 = new System.Windows.Forms.CheckBox();
            this.Hide3 = new System.Windows.Forms.CheckBox();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.textBoxU0 = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxV0 = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelU0 = new System.Windows.Forms.Label();
            this.labelV0 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.drawU = new System.Windows.Forms.CheckBox();
            this.drawV = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(372, 12);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(1540, 562);
            this.zedGraphControl.TabIndex = 0;
            // 
            // problem
            // 
            this.problem.AccessibleDescription = "";
            this.problem.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "6",
            "8",
            "18",
            "21"});
            this.problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.problem.FormattingEnabled = true;
            this.problem.Items.AddRange(new object[] {
            "5",
            "12,3",
            "13,1",
            "17"});
            this.problem.Location = new System.Drawing.Point(26, 46);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(309, 33);
            this.problem.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Start.Location = new System.Drawing.Point(26, 509);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(309, 65);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // number_of_nodes
            // 
            this.number_of_nodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_nodes.Location = new System.Drawing.Point(23, 282);
            this.number_of_nodes.Name = "number_of_nodes";
            this.number_of_nodes.Size = new System.Drawing.Size(312, 31);
            this.number_of_nodes.TabIndex = 4;
            this.number_of_nodes.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(10, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество узлов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(20, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Задача:";
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.error1.Location = new System.Drawing.Point(18, 586);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(322, 31);
            this.error1.TabIndex = 9;
            this.error1.Text = "Пошрешность метода1: ";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(26, 708);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.Size = new System.Drawing.Size(1886, 294);
            this.grid.TabIndex = 11;
            // 
            // Epsilon
            // 
            this.Epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Epsilon.Location = new System.Drawing.Point(26, 198);
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(309, 31);
            this.Epsilon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Параметр:";
            // 
            // number_of_subnodes
            // 
            this.number_of_subnodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_subnodes.Location = new System.Drawing.Point(62, 361);
            this.number_of_subnodes.Name = "number_of_subnodes";
            this.number_of_subnodes.Size = new System.Drawing.Size(162, 31);
            this.number_of_subnodes.TabIndex = 14;
            // 
            // number_of_subsubnodes
            // 
            this.number_of_subsubnodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_subsubnodes.Location = new System.Drawing.Point(62, 430);
            this.number_of_subsubnodes.Name = "number_of_subsubnodes";
            this.number_of_subsubnodes.Size = new System.Drawing.Size(162, 31);
            this.number_of_subsubnodes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(20, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "λ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(18, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "σ:";
            // 
            // Hide1
            // 
            this.Hide1.AutoSize = true;
            this.Hide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide1.Location = new System.Drawing.Point(241, 338);
            this.Hide1.Name = "Hide1";
            this.Hide1.Size = new System.Drawing.Size(105, 29);
            this.Hide1.TabIndex = 18;
            this.Hide1.Text = "Скрыть";
            this.Hide1.UseVisualStyleBackColor = true;
            // 
            // Hide2
            // 
            this.Hide2.AutoSize = true;
            this.Hide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide2.Location = new System.Drawing.Point(241, 393);
            this.Hide2.Name = "Hide2";
            this.Hide2.Size = new System.Drawing.Size(105, 29);
            this.Hide2.TabIndex = 19;
            this.Hide2.Text = "Скрыть";
            this.Hide2.UseVisualStyleBackColor = true;
            // 
            // Hide3
            // 
            this.Hide3.AutoSize = true;
            this.Hide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide3.Location = new System.Drawing.Point(241, 453);
            this.Hide3.Name = "Hide3";
            this.Hide3.Size = new System.Drawing.Size(105, 29);
            this.Hide3.TabIndex = 20;
            this.Hide3.Text = "Скрыть";
            this.Hide3.UseVisualStyleBackColor = true;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.error2.Location = new System.Drawing.Point(20, 628);
            this.error2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(322, 31);
            this.error2.TabIndex = 21;
            this.error2.Text = "Пошрешность метода2: ";
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.error3.Location = new System.Drawing.Point(20, 673);
            this.error3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(322, 31);
            this.error3.TabIndex = 22;
            this.error3.Text = "Пошрешность метода3: ";
            // 
            // textBoxU0
            // 
            this.textBoxU0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxU0.Location = new System.Drawing.Point(1062, 633);
            this.textBoxU0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxU0.Name = "textBoxU0";
            this.textBoxU0.Size = new System.Drawing.Size(103, 38);
            this.textBoxU0.TabIndex = 23;
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxA.Location = new System.Drawing.Point(1273, 587);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(98, 38);
            this.textBoxA.TabIndex = 24;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxB.Location = new System.Drawing.Point(1062, 584);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(103, 38);
            this.textBoxB.TabIndex = 25;
            // 
            // textBoxV0
            // 
            this.textBoxV0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxV0.Location = new System.Drawing.Point(1273, 629);
            this.textBoxV0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxV0.Name = "textBoxV0";
            this.textBoxV0.Size = new System.Drawing.Size(98, 38);
            this.textBoxV0.TabIndex = 26;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelA.Location = new System.Drawing.Point(1020, 586);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(37, 31);
            this.labelA.TabIndex = 27;
            this.labelA.Text = "a:";
            // 
            // labelU0
            // 
            this.labelU0.AutoSize = true;
            this.labelU0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelU0.Location = new System.Drawing.Point(1000, 640);
            this.labelU0.Name = "labelU0";
            this.labelU0.Size = new System.Drawing.Size(57, 31);
            this.labelU0.TabIndex = 28;
            this.labelU0.Text = "U0:";
            // 
            // labelV0
            // 
            this.labelV0.AutoSize = true;
            this.labelV0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelV0.Location = new System.Drawing.Point(1213, 636);
            this.labelV0.Name = "labelV0";
            this.labelV0.Size = new System.Drawing.Size(55, 31);
            this.labelV0.TabIndex = 29;
            this.labelV0.Text = "V0:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelB.Location = new System.Drawing.Point(1231, 584);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(37, 31);
            this.labelB.TabIndex = 30;
            this.labelB.Text = "b:";
            // 
            // drawU
            // 
            this.drawU.AutoSize = true;
            this.drawU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.drawU.Location = new System.Drawing.Point(1385, 589);
            this.drawU.Name = "drawU";
            this.drawU.Size = new System.Drawing.Size(150, 35);
            this.drawU.TabIndex = 31;
            this.drawU.Text = "Draw U(t)";
            this.drawU.UseVisualStyleBackColor = true;
            // 
            // drawV
            // 
            this.drawV.AutoSize = true;
            this.drawV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.drawV.Location = new System.Drawing.Point(1387, 633);
            this.drawV.Name = "drawV";
            this.drawV.Size = new System.Drawing.Size(148, 35);
            this.drawV.TabIndex = 32;
            this.drawV.Text = "Draw V(t)";
            this.drawV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 845);
            this.Controls.Add(this.drawV);
            this.Controls.Add(this.drawU);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelV0);
            this.Controls.Add(this.labelU0);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxV0);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxU0);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.Hide3);
            this.Controls.Add(this.Hide2);
            this.Controls.Add(this.Hide1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.number_of_subsubnodes);
            this.Controls.Add(this.number_of_subnodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_nodes);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.zedGraphControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.ComboBox problem;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox number_of_nodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox Epsilon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number_of_subnodes;
        private System.Windows.Forms.TextBox number_of_subsubnodes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Hide1;
        private System.Windows.Forms.CheckBox Hide2;
        private System.Windows.Forms.CheckBox Hide3;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.TextBox textBoxU0;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxV0;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelU0;
        private System.Windows.Forms.Label labelV0;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.CheckBox drawU;
        private System.Windows.Forms.CheckBox drawV;
    }
}

