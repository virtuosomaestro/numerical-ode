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
            this.error = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(496, 15);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(2053, 692);
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
            this.problem.Location = new System.Drawing.Point(35, 57);
            this.problem.Margin = new System.Windows.Forms.Padding(4);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(411, 37);
            this.problem.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Start.Location = new System.Drawing.Point(35, 626);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(412, 80);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // number_of_nodes
            // 
            this.number_of_nodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_nodes.Location = new System.Drawing.Point(31, 347);
            this.number_of_nodes.Margin = new System.Windows.Forms.Padding(4);
            this.number_of_nodes.Name = "number_of_nodes";
            this.number_of_nodes.Size = new System.Drawing.Size(415, 36);
            this.number_of_nodes.TabIndex = 4;
            this.number_of_nodes.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(13, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество узлов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(27, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Задача:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.error.Location = new System.Drawing.Point(27, 823);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 39);
            this.error.TabIndex = 9;
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
            this.grid.Location = new System.Drawing.Point(35, 871);
            this.grid.Margin = new System.Windows.Forms.Padding(4);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.Size = new System.Drawing.Size(2515, 362);
            this.grid.TabIndex = 11;
            // 
            // Epsilon
            // 
            this.Epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Epsilon.Location = new System.Drawing.Point(35, 244);
            this.Epsilon.Margin = new System.Windows.Forms.Padding(4);
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(411, 36);
            this.Epsilon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(27, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Параметр:";
            // 
            // number_of_subnodes
            // 
            this.number_of_subnodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_subnodes.Location = new System.Drawing.Point(83, 444);
            this.number_of_subnodes.Margin = new System.Windows.Forms.Padding(4);
            this.number_of_subnodes.Name = "number_of_subnodes";
            this.number_of_subnodes.Size = new System.Drawing.Size(215, 36);
            this.number_of_subnodes.TabIndex = 14;
            // 
            // number_of_subsubnodes
            // 
            this.number_of_subsubnodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.number_of_subsubnodes.Location = new System.Drawing.Point(83, 529);
            this.number_of_subsubnodes.Margin = new System.Windows.Forms.Padding(4);
            this.number_of_subsubnodes.Name = "number_of_subsubnodes";
            this.number_of_subsubnodes.Size = new System.Drawing.Size(215, 36);
            this.number_of_subsubnodes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(27, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "λ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(24, 529);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 39);
            this.label6.TabIndex = 17;
            this.label6.Text = "σ:";
            // 
            // Hide1
            // 
            this.Hide1.AutoSize = true;
            this.Hide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide1.Location = new System.Drawing.Point(361, 417);
            this.Hide1.Margin = new System.Windows.Forms.Padding(4);
            this.Hide1.Name = "Hide1";
            this.Hide1.Size = new System.Drawing.Size(126, 34);
            this.Hide1.TabIndex = 18;
            this.Hide1.Text = "Скрыть";
            this.Hide1.UseVisualStyleBackColor = true;
            // 
            // Hide2
            // 
            this.Hide2.AutoSize = true;
            this.Hide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide2.Location = new System.Drawing.Point(361, 484);
            this.Hide2.Margin = new System.Windows.Forms.Padding(4);
            this.Hide2.Name = "Hide2";
            this.Hide2.Size = new System.Drawing.Size(126, 34);
            this.Hide2.TabIndex = 19;
            this.Hide2.Text = "Скрыть";
            this.Hide2.UseVisualStyleBackColor = true;
            // 
            // Hide3
            // 
            this.Hide3.AutoSize = true;
            this.Hide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Hide3.Location = new System.Drawing.Point(361, 552);
            this.Hide3.Margin = new System.Windows.Forms.Padding(4);
            this.Hide3.Name = "Hide3";
            this.Hide3.Size = new System.Drawing.Size(126, 34);
            this.Hide3.TabIndex = 20;
            this.Hide3.Text = "Скрыть";
            this.Hide3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
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
            this.Controls.Add(this.error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_nodes);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.zedGraphControl);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label error;
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
    }
}

