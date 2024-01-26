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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.lbllength = new System.Windows.Forms.Label();
            this.lblinertia = new System.Windows.Forms.Label();
            this.txtModulusElasticity = new System.Windows.Forms.TextBox();
            this.lblModulusElasticity = new System.Windows.Forms.Label();
            this.txtInertia = new System.Windows.Forms.TextBox();
            this.lblload = new System.Windows.Forms.Label();
            this.txtload = new System.Windows.Forms.TextBox();
            this.txtDisplacement = new System.Windows.Forms.TextBox();
            this.lbldisplacement = new System.Windows.Forms.Label();
            this.txtForceWidth = new System.Windows.Forms.TextBox();
            this.lblUFwidth = new System.Windows.Forms.Label();
            this.radSinglePointForce = new System.Windows.Forms.RadioButton();
            this.radUniformAreaForce = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblmaxdeflection = new System.Windows.Forms.Label();
            this.txtMaxDeflection = new System.Windows.Forms.TextBox();
            this.chrtDeflectionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbldepth = new System.Windows.Forms.Label();
            this.txtdepth = new System.Windows.Forms.TextBox();
            this.lblbreadth = new System.Windows.Forms.Label();
            this.txtbreadth = new System.Windows.Forms.TextBox();
            this.radTimberBeamMD = new System.Windows.Forms.RadioButton();
            this.cmboTimberClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDeflectionGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlength
            // 
            this.txtlength.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtlength.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtlength.Location = new System.Drawing.Point(81, 250);
            this.txtlength.Margin = new System.Windows.Forms.Padding(2);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(35, 20);
            this.txtlength.TabIndex = 0;
            this.txtlength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlength.TextChanged += new System.EventHandler(this.txtlength_TextChanged);
            this.txtlength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlength_KeyPress);
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Location = new System.Drawing.Point(26, 252);
            this.lbllength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(53, 13);
            this.lbllength.TabIndex = 1;
            this.lbllength.Text = "length (m)";
            this.lbllength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinertia
            // 
            this.lblinertia.AutoSize = true;
            this.lblinertia.Location = new System.Drawing.Point(94, 439);
            this.lblinertia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinertia.Name = "lblinertia";
            this.lblinertia.Size = new System.Drawing.Size(65, 13);
            this.lblinertia.TabIndex = 3;
            this.lblinertia.Text = "Inertia (m^4)";
            // 
            // txtModulusElasticity
            // 
            this.txtModulusElasticity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtModulusElasticity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtModulusElasticity.Location = new System.Drawing.Point(163, 387);
            this.txtModulusElasticity.Margin = new System.Windows.Forms.Padding(2);
            this.txtModulusElasticity.Name = "txtModulusElasticity";
            this.txtModulusElasticity.Size = new System.Drawing.Size(35, 20);
            this.txtModulusElasticity.TabIndex = 2;
            this.txtModulusElasticity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModulusElasticity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulusElasticity_KeyPress);
            // 
            // lblModulusElasticity
            // 
            this.lblModulusElasticity.AutoSize = true;
            this.lblModulusElasticity.Location = new System.Drawing.Point(26, 387);
            this.lblModulusElasticity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModulusElasticity.Name = "lblModulusElasticity";
            this.lblModulusElasticity.Size = new System.Drawing.Size(136, 13);
            this.lblModulusElasticity.TabIndex = 5;
            this.lblModulusElasticity.Text = "modulusElasticity (kM/m^2)";
            // 
            // txtInertia
            // 
            this.txtInertia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInertia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtInertia.Location = new System.Drawing.Point(163, 437);
            this.txtInertia.Margin = new System.Windows.Forms.Padding(2);
            this.txtInertia.Name = "txtInertia";
            this.txtInertia.Size = new System.Drawing.Size(35, 20);
            this.txtInertia.TabIndex = 4;
            this.txtInertia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInertia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInertia_KeyPress);
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Location = new System.Drawing.Point(104, 342);
            this.lblload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(50, 13);
            this.lblload.TabIndex = 7;
            this.lblload.Text = "load (kN)";
            this.lblload.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtload
            // 
            this.txtload.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtload.Location = new System.Drawing.Point(163, 338);
            this.txtload.Margin = new System.Windows.Forms.Padding(2);
            this.txtload.Name = "txtload";
            this.txtload.Size = new System.Drawing.Size(35, 20);
            this.txtload.TabIndex = 6;
            this.txtload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtload.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtload_KeyPress);
            // 
            // txtDisplacement
            // 
            this.txtDisplacement.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDisplacement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDisplacement.Location = new System.Drawing.Point(163, 484);
            this.txtDisplacement.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplacement.Name = "txtDisplacement";
            this.txtDisplacement.Size = new System.Drawing.Size(35, 20);
            this.txtDisplacement.TabIndex = 9;
            this.txtDisplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplacement_KeyPress);
            // 
            // lbldisplacement
            // 
            this.lbldisplacement.AutoSize = true;
            this.lbldisplacement.Location = new System.Drawing.Point(70, 488);
            this.lbldisplacement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldisplacement.Name = "lbldisplacement";
            this.lbldisplacement.Size = new System.Drawing.Size(88, 13);
            this.lbldisplacement.TabIndex = 8;
            this.lbldisplacement.Text = "Displacement (m)";
            // 
            // txtForceWidth
            // 
            this.txtForceWidth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForceWidth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtForceWidth.Location = new System.Drawing.Point(163, 534);
            this.txtForceWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtForceWidth.Name = "txtForceWidth";
            this.txtForceWidth.Size = new System.Drawing.Size(35, 20);
            this.txtForceWidth.TabIndex = 11;
            this.txtForceWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtForceWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForceWidth_KeyPress);
            // 
            // lblUFwidth
            // 
            this.lblUFwidth.AutoSize = true;
            this.lblUFwidth.Location = new System.Drawing.Point(40, 538);
            this.lblUFwidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUFwidth.Name = "lblUFwidth";
            this.lblUFwidth.Size = new System.Drawing.Size(118, 13);
            this.lblUFwidth.TabIndex = 10;
            this.lblUFwidth.Text = "UniformForce Width (m)";
            // 
            // radSinglePointForce
            // 
            this.radSinglePointForce.AutoSize = true;
            this.radSinglePointForce.Location = new System.Drawing.Point(115, 156);
            this.radSinglePointForce.Margin = new System.Windows.Forms.Padding(2);
            this.radSinglePointForce.Name = "radSinglePointForce";
            this.radSinglePointForce.Size = new System.Drawing.Size(128, 17);
            this.radSinglePointForce.TabIndex = 13;
            this.radSinglePointForce.TabStop = true;
            this.radSinglePointForce.Text = "SinglePointForce-M.D";
            this.radSinglePointForce.UseVisualStyleBackColor = true;
            this.radSinglePointForce.CheckedChanged += new System.EventHandler(this.radSinglePointForce_CheckedChanged);
            // 
            // radUniformAreaForce
            // 
            this.radUniformAreaForce.AutoSize = true;
            this.radUniformAreaForce.Location = new System.Drawing.Point(115, 121);
            this.radUniformAreaForce.Margin = new System.Windows.Forms.Padding(2);
            this.radUniformAreaForce.Name = "radUniformAreaForce";
            this.radUniformAreaForce.Size = new System.Drawing.Size(133, 17);
            this.radUniformAreaForce.TabIndex = 14;
            this.radUniformAreaForce.TabStop = true;
            this.radUniformAreaForce.Text = "UniformAreaForce-M.D";
            this.radUniformAreaForce.UseVisualStyleBackColor = true;
            this.radUniformAreaForce.CheckedChanged += new System.EventHandler(this.radUniformAreaForce_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(449, 82);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 71);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCalculate_KeyDown);
            // 
            // lblmaxdeflection
            // 
            this.lblmaxdeflection.AutoSize = true;
            this.lblmaxdeflection.Location = new System.Drawing.Point(677, 91);
            this.lblmaxdeflection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaxdeflection.Name = "lblmaxdeflection";
            this.lblmaxdeflection.Size = new System.Drawing.Size(100, 13);
            this.lblmaxdeflection.TabIndex = 16;
            this.lblmaxdeflection.Text = "MaxDeflection (mm)";
            this.lblmaxdeflection.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaxDeflection
            // 
            this.txtMaxDeflection.Location = new System.Drawing.Point(680, 121);
            this.txtMaxDeflection.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxDeflection.Name = "txtMaxDeflection";
            this.txtMaxDeflection.ReadOnly = true;
            this.txtMaxDeflection.Size = new System.Drawing.Size(471, 20);
            this.txtMaxDeflection.TabIndex = 17;
            this.txtMaxDeflection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxDeflection_KeyPress);
            // 
            // chrtDeflectionGraph
            // 
            this.chrtDeflectionGraph.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chrtDeflectionGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtDeflectionGraph.Legends.Add(legend3);
            this.chrtDeflectionGraph.Location = new System.Drawing.Point(269, 351);
            this.chrtDeflectionGraph.Margin = new System.Windows.Forms.Padding(2);
            this.chrtDeflectionGraph.Name = "chrtDeflectionGraph";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtDeflectionGraph.Series.Add(series3);
            this.chrtDeflectionGraph.Size = new System.Drawing.Size(976, 306);
            this.chrtDeflectionGraph.TabIndex = 18;
            this.chrtDeflectionGraph.Text = "chart1";
            // 
            // lbldepth
            // 
            this.lbldepth.AutoSize = true;
            this.lbldepth.Location = new System.Drawing.Point(132, 252);
            this.lbldepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldepth.Name = "lbldepth";
            this.lbldepth.Size = new System.Drawing.Size(51, 13);
            this.lbldepth.TabIndex = 20;
            this.lbldepth.Text = "depth (m)";
            // 
            // txtdepth
            // 
            this.txtdepth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtdepth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtdepth.Location = new System.Drawing.Point(187, 250);
            this.txtdepth.Margin = new System.Windows.Forms.Padding(2);
            this.txtdepth.Name = "txtdepth";
            this.txtdepth.Size = new System.Drawing.Size(35, 20);
            this.txtdepth.TabIndex = 19;
            this.txtdepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblbreadth
            // 
            this.lblbreadth.AutoSize = true;
            this.lblbreadth.Location = new System.Drawing.Point(232, 254);
            this.lblbreadth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbreadth.Name = "lblbreadth";
            this.lblbreadth.Size = new System.Drawing.Size(60, 13);
            this.lblbreadth.TabIndex = 22;
            this.lblbreadth.Text = "breadth (m)";
            // 
            // txtbreadth
            // 
            this.txtbreadth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbreadth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbreadth.Location = new System.Drawing.Point(297, 252);
            this.txtbreadth.Margin = new System.Windows.Forms.Padding(2);
            this.txtbreadth.Name = "txtbreadth";
            this.txtbreadth.Size = new System.Drawing.Size(35, 20);
            this.txtbreadth.TabIndex = 21;
            this.txtbreadth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radTimberBeamMD
            // 
            this.radTimberBeamMD.AutoSize = true;
            this.radTimberBeamMD.Location = new System.Drawing.Point(269, 121);
            this.radTimberBeamMD.Margin = new System.Windows.Forms.Padding(2);
            this.radTimberBeamMD.Name = "radTimberBeamMD";
            this.radTimberBeamMD.Size = new System.Drawing.Size(136, 17);
            this.radTimberBeamMD.TabIndex = 23;
            this.radTimberBeamMD.TabStop = true;
            this.radTimberBeamMD.Text = "TimberBeamCalculation";
            this.radTimberBeamMD.UseVisualStyleBackColor = true;
            this.radTimberBeamMD.CheckedChanged += new System.EventHandler(this.radTimberBeamMD_CheckedChanged);
            // 
            // cmboTimberClass
            // 
            this.cmboTimberClass.FormattingEnabled = true;
            this.cmboTimberClass.Location = new System.Drawing.Point(269, 155);
            this.cmboTimberClass.Name = "cmboTimberClass";
            this.cmboTimberClass.Size = new System.Drawing.Size(121, 21);
            this.cmboTimberClass.TabIndex = 24;
            this.cmboTimberClass.TextChanged += new System.EventHandler(this.cmboTimberClass_TextChanged);
            // 
            // frmBeamCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 746);
            this.Controls.Add(this.cmboTimberClass);
            this.Controls.Add(this.radTimberBeamMD);
            this.Controls.Add(this.lblbreadth);
            this.Controls.Add(this.txtbreadth);
            this.Controls.Add(this.lbldepth);
            this.Controls.Add(this.txtdepth);
            this.Controls.Add(this.chrtDeflectionGraph);
            this.Controls.Add(this.txtMaxDeflection);
            this.Controls.Add(this.lblmaxdeflection);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radUniformAreaForce);
            this.Controls.Add(this.radSinglePointForce);
            this.Controls.Add(this.txtForceWidth);
            this.Controls.Add(this.lblUFwidth);
            this.Controls.Add(this.txtDisplacement);
            this.Controls.Add(this.lbldisplacement);
            this.Controls.Add(this.lblload);
            this.Controls.Add(this.txtload);
            this.Controls.Add(this.lblModulusElasticity);
            this.Controls.Add(this.txtInertia);
            this.Controls.Add(this.lblinertia);
            this.Controls.Add(this.txtModulusElasticity);
            this.Controls.Add(this.lbllength);
            this.Controls.Add(this.txtlength);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBeamCalculation";
            this.Text = "haiders calculator";
            this.Load += new System.EventHandler(this.frmBeamCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtDeflectionGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.Label lblinertia;
        private System.Windows.Forms.TextBox txtModulusElasticity;
        private System.Windows.Forms.Label lblModulusElasticity;
        private System.Windows.Forms.TextBox txtInertia;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.TextBox txtload;
        private System.Windows.Forms.TextBox txtDisplacement;
        private System.Windows.Forms.Label lbldisplacement;
        private System.Windows.Forms.TextBox txtForceWidth;
        private System.Windows.Forms.Label lblUFwidth;
        private System.Windows.Forms.RadioButton radSinglePointForce;
        private System.Windows.Forms.RadioButton radUniformAreaForce;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblmaxdeflection;
        private System.Windows.Forms.TextBox txtMaxDeflection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDeflectionGraph;
        private System.Windows.Forms.Label lbldepth;
        private System.Windows.Forms.TextBox txtdepth;
        private System.Windows.Forms.Label lblbreadth;
        private System.Windows.Forms.TextBox txtbreadth;
        private System.Windows.Forms.RadioButton radTimberBeamMD;
        private System.Windows.Forms.ComboBox cmboTimberClass;
    }
}

