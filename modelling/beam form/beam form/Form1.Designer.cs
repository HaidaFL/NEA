namespace beam_form
{
    partial class frmBeamCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModulusElasticity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInertia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtload = new System.Windows.Forms.TextBox();
            this.txtDisplacement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtForceWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radSinglePointForce = new System.Windows.Forms.RadioButton();
            this.radUniformAreaForce = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxDeflection = new System.Windows.Forms.TextBox();
            this.chrtDeflectionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDeflectionGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlength
            // 
            this.txtlength.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtlength.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtlength.Location = new System.Drawing.Point(245, 447);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(51, 26);
            this.txtlength.TabIndex = 0;
            this.txtlength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlength.TextChanged += new System.EventHandler(this.txtlength_TextChanged);
            this.txtlength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlength_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "length";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inertia";
            // 
            // txtModulusElasticity
            // 
            this.txtModulusElasticity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtModulusElasticity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtModulusElasticity.Location = new System.Drawing.Point(245, 595);
            this.txtModulusElasticity.Name = "txtModulusElasticity";
            this.txtModulusElasticity.Size = new System.Drawing.Size(51, 26);
            this.txtModulusElasticity.TabIndex = 2;
            this.txtModulusElasticity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModulusElasticity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulusElasticity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "modulusElasticity";
            // 
            // txtInertia
            // 
            this.txtInertia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInertia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtInertia.Location = new System.Drawing.Point(245, 672);
            this.txtInertia.Name = "txtInertia";
            this.txtInertia.Size = new System.Drawing.Size(51, 26);
            this.txtInertia.TabIndex = 4;
            this.txtInertia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInertia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInertia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "load";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtload
            // 
            this.txtload.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtload.Location = new System.Drawing.Point(245, 520);
            this.txtload.Name = "txtload";
            this.txtload.Size = new System.Drawing.Size(51, 26);
            this.txtload.TabIndex = 6;
            this.txtload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtload.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtload_KeyPress);
            // 
            // txtDisplacement
            // 
            this.txtDisplacement.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDisplacement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDisplacement.Location = new System.Drawing.Point(245, 745);
            this.txtDisplacement.Name = "txtDisplacement";
            this.txtDisplacement.Size = new System.Drawing.Size(51, 26);
            this.txtDisplacement.TabIndex = 9;
            this.txtDisplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplacement_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 751);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Displacement";
            // 
            // txtForceWidth
            // 
            this.txtForceWidth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForceWidth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtForceWidth.Location = new System.Drawing.Point(245, 821);
            this.txtForceWidth.Name = "txtForceWidth";
            this.txtForceWidth.Size = new System.Drawing.Size(51, 26);
            this.txtForceWidth.TabIndex = 11;
            this.txtForceWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtForceWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForceWidth_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 827);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "UniformForce Width";
            // 
            // radSinglePointForce
            // 
            this.radSinglePointForce.AutoSize = true;
            this.radSinglePointForce.Location = new System.Drawing.Point(122, 193);
            this.radSinglePointForce.Name = "radSinglePointForce";
            this.radSinglePointForce.Size = new System.Drawing.Size(189, 24);
            this.radSinglePointForce.TabIndex = 13;
            this.radSinglePointForce.TabStop = true;
            this.radSinglePointForce.Text = "SinglePointForce-M.D";
            this.radSinglePointForce.UseVisualStyleBackColor = true;
            this.radSinglePointForce.CheckedChanged += new System.EventHandler(this.radSinglePointForce_CheckedChanged);
            // 
            // radUniformAreaForce
            // 
            this.radUniformAreaForce.AutoSize = true;
            this.radUniformAreaForce.Location = new System.Drawing.Point(122, 75);
            this.radUniformAreaForce.Name = "radUniformAreaForce";
            this.radUniformAreaForce.Size = new System.Drawing.Size(199, 24);
            this.radUniformAreaForce.TabIndex = 14;
            this.radUniformAreaForce.TabStop = true;
            this.radUniformAreaForce.Text = "UniformAreaForce-M.D";
            this.radUniformAreaForce.UseVisualStyleBackColor = true;
            this.radUniformAreaForce.CheckedChanged += new System.EventHandler(this.radUniformAreaForce_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(378, 788);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(436, 184);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 1029);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "MaxDeflection ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaxDeflection
            // 
            this.txtMaxDeflection.Location = new System.Drawing.Point(122, 1071);
            this.txtMaxDeflection.Name = "txtMaxDeflection";
            this.txtMaxDeflection.ReadOnly = true;
            this.txtMaxDeflection.Size = new System.Drawing.Size(1612, 26);
            this.txtMaxDeflection.TabIndex = 17;
            this.txtMaxDeflection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxDeflection_KeyPress);
            // 
            // chrtDeflectionGraph
            // 
            this.chrtDeflectionGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrtDeflectionGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtDeflectionGraph.Legends.Add(legend1);
            this.chrtDeflectionGraph.Location = new System.Drawing.Point(393, 193);
            this.chrtDeflectionGraph.Name = "chrtDeflectionGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtDeflectionGraph.Series.Add(series1);
            this.chrtDeflectionGraph.Size = new System.Drawing.Size(1464, 471);
            this.chrtDeflectionGraph.TabIndex = 18;
            this.chrtDeflectionGraph.Text = "chart1";
            // 
            // frmBeamCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1869, 1167);
            this.Controls.Add(this.chrtDeflectionGraph);
            this.Controls.Add(this.txtMaxDeflection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radUniformAreaForce);
            this.Controls.Add(this.radSinglePointForce);
            this.Controls.Add(this.txtForceWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDisplacement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInertia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModulusElasticity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlength);
            this.Name = "frmBeamCalculation";
            this.Text = "haiders calculator";
            this.Load += new System.EventHandler(this.frmBeamCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtDeflectionGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModulusElasticity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInertia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtload;
        private System.Windows.Forms.TextBox txtDisplacement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtForceWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radSinglePointForce;
        private System.Windows.Forms.RadioButton radUniformAreaForce;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxDeflection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDeflectionGraph;
    }
}

