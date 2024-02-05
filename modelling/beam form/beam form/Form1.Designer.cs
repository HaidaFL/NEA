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
            this.cmbodepth = new System.Windows.Forms.ComboBox();
            this.cmbobreadth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDeflectionGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlength
            // 
            this.txtlength.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtlength.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtlength.Location = new System.Drawing.Point(122, 385);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(50, 26);
            this.txtlength.TabIndex = 0;
            this.txtlength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlength.TextChanged += new System.EventHandler(this.txtlength_TextChanged);
            this.txtlength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlength_KeyPress);
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Location = new System.Drawing.Point(39, 388);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(80, 20);
            this.lbllength.TabIndex = 1;
            this.lbllength.Text = "length (m)";
            this.lbllength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinertia
            // 
            this.lblinertia.AutoSize = true;
            this.lblinertia.Location = new System.Drawing.Point(141, 675);
            this.lblinertia.Name = "lblinertia";
            this.lblinertia.Size = new System.Drawing.Size(97, 20);
            this.lblinertia.TabIndex = 3;
            this.lblinertia.Text = "Inertia (m^4)";
            // 
            // txtModulusElasticity
            // 
            this.txtModulusElasticity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtModulusElasticity.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtModulusElasticity.Location = new System.Drawing.Point(244, 595);
            this.txtModulusElasticity.Name = "txtModulusElasticity";
            this.txtModulusElasticity.Size = new System.Drawing.Size(50, 26);
            this.txtModulusElasticity.TabIndex = 2;
            this.txtModulusElasticity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModulusElasticity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModulusElasticity_KeyPress);
            // 
            // lblModulusElasticity
            // 
            this.lblModulusElasticity.AutoSize = true;
            this.lblModulusElasticity.Location = new System.Drawing.Point(39, 595);
            this.lblModulusElasticity.Name = "lblModulusElasticity";
            this.lblModulusElasticity.Size = new System.Drawing.Size(199, 20);
            this.lblModulusElasticity.TabIndex = 5;
            this.lblModulusElasticity.Text = "modulusElasticity (kM/m^2)";
            // 
            // txtInertia
            // 
            this.txtInertia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInertia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtInertia.Location = new System.Drawing.Point(244, 672);
            this.txtInertia.Name = "txtInertia";
            this.txtInertia.Size = new System.Drawing.Size(50, 26);
            this.txtInertia.TabIndex = 4;
            this.txtInertia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInertia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInertia_KeyPress);
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Location = new System.Drawing.Point(156, 526);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(72, 20);
            this.lblload.TabIndex = 7;
            this.lblload.Text = "load (kN)";
            this.lblload.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtload
            // 
            this.txtload.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtload.Location = new System.Drawing.Point(244, 520);
            this.txtload.Name = "txtload";
            this.txtload.Size = new System.Drawing.Size(50, 26);
            this.txtload.TabIndex = 6;
            this.txtload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtload.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtload_KeyPress);
            // 
            // txtDisplacement
            // 
            this.txtDisplacement.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDisplacement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDisplacement.Location = new System.Drawing.Point(244, 745);
            this.txtDisplacement.Name = "txtDisplacement";
            this.txtDisplacement.Size = new System.Drawing.Size(50, 26);
            this.txtDisplacement.TabIndex = 9;
            this.txtDisplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplacement_KeyPress);
            // 
            // lbldisplacement
            // 
            this.lbldisplacement.AutoSize = true;
            this.lbldisplacement.Location = new System.Drawing.Point(105, 751);
            this.lbldisplacement.Name = "lbldisplacement";
            this.lbldisplacement.Size = new System.Drawing.Size(133, 20);
            this.lbldisplacement.TabIndex = 8;
            this.lbldisplacement.Text = "Displacement (m)";
            // 
            // txtForceWidth
            // 
            this.txtForceWidth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForceWidth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtForceWidth.Location = new System.Drawing.Point(244, 822);
            this.txtForceWidth.Name = "txtForceWidth";
            this.txtForceWidth.Size = new System.Drawing.Size(50, 26);
            this.txtForceWidth.TabIndex = 11;
            this.txtForceWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtForceWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForceWidth_KeyPress);
            // 
            // lblUFwidth
            // 
            this.lblUFwidth.AutoSize = true;
            this.lblUFwidth.Location = new System.Drawing.Point(60, 828);
            this.lblUFwidth.Name = "lblUFwidth";
            this.lblUFwidth.Size = new System.Drawing.Size(178, 20);
            this.lblUFwidth.TabIndex = 10;
            this.lblUFwidth.Text = "UniformForce Width (m)";
            // 
            // radSinglePointForce
            // 
            this.radSinglePointForce.AutoSize = true;
            this.radSinglePointForce.Location = new System.Drawing.Point(43, 136);
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
            this.radUniformAreaForce.Location = new System.Drawing.Point(43, 86);
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
            this.btnCalculate.Location = new System.Drawing.Point(676, 425);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(244, 109);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCalculate_KeyDown);
            // 
            // lblmaxdeflection
            // 
            this.lblmaxdeflection.AutoSize = true;
            this.lblmaxdeflection.Location = new System.Drawing.Point(954, 435);
            this.lblmaxdeflection.Name = "lblmaxdeflection";
            this.lblmaxdeflection.Size = new System.Drawing.Size(150, 20);
            this.lblmaxdeflection.TabIndex = 16;
            this.lblmaxdeflection.Text = "MaxDeflection (mm)";
            this.lblmaxdeflection.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtMaxDeflection
            // 
            this.txtMaxDeflection.Location = new System.Drawing.Point(958, 508);
            this.txtMaxDeflection.Name = "txtMaxDeflection";
            this.txtMaxDeflection.ReadOnly = true;
            this.txtMaxDeflection.Size = new System.Drawing.Size(704, 26);
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
            this.chrtDeflectionGraph.Location = new System.Drawing.Point(404, 540);
            this.chrtDeflectionGraph.Name = "chrtDeflectionGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtDeflectionGraph.Series.Add(series1);
            this.chrtDeflectionGraph.Size = new System.Drawing.Size(1464, 471);
            this.chrtDeflectionGraph.TabIndex = 18;
            this.chrtDeflectionGraph.Text = "chart1";
            // 
            // lbldepth
            // 
            this.lbldepth.AutoSize = true;
            this.lbldepth.Location = new System.Drawing.Point(198, 388);
            this.lbldepth.Name = "lbldepth";
            this.lbldepth.Size = new System.Drawing.Size(77, 20);
            this.lbldepth.TabIndex = 20;
            this.lbldepth.Text = "depth (m)";
            // 
            // txtdepth
            // 
            this.txtdepth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtdepth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtdepth.Location = new System.Drawing.Point(280, 385);
            this.txtdepth.Name = "txtdepth";
            this.txtdepth.Size = new System.Drawing.Size(50, 26);
            this.txtdepth.TabIndex = 19;
            this.txtdepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblbreadth
            // 
            this.lblbreadth.AutoSize = true;
            this.lblbreadth.Location = new System.Drawing.Point(348, 391);
            this.lblbreadth.Name = "lblbreadth";
            this.lblbreadth.Size = new System.Drawing.Size(91, 20);
            this.lblbreadth.TabIndex = 22;
            this.lblbreadth.Text = "breadth (m)";
            // 
            // txtbreadth
            // 
            this.txtbreadth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtbreadth.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbreadth.Location = new System.Drawing.Point(446, 388);
            this.txtbreadth.Name = "txtbreadth";
            this.txtbreadth.Size = new System.Drawing.Size(50, 26);
            this.txtbreadth.TabIndex = 21;
            this.txtbreadth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radTimberBeamMD
            // 
            this.radTimberBeamMD.AutoSize = true;
            this.radTimberBeamMD.Location = new System.Drawing.Point(664, 86);
            this.radTimberBeamMD.Name = "radTimberBeamMD";
            this.radTimberBeamMD.Size = new System.Drawing.Size(202, 24);
            this.radTimberBeamMD.TabIndex = 23;
            this.radTimberBeamMD.TabStop = true;
            this.radTimberBeamMD.Text = "TimberBeamCalculation";
            this.radTimberBeamMD.UseVisualStyleBackColor = true;
            this.radTimberBeamMD.CheckedChanged += new System.EventHandler(this.radTimberBeamMD_CheckedChanged);
            // 
            // cmboTimberClass
            // 
            this.cmboTimberClass.FormattingEnabled = true;
            this.cmboTimberClass.Location = new System.Drawing.Point(676, 132);
            this.cmboTimberClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboTimberClass.Name = "cmboTimberClass";
            this.cmboTimberClass.Size = new System.Drawing.Size(180, 28);
            this.cmboTimberClass.TabIndex = 24;
            this.cmboTimberClass.TextChanged += new System.EventHandler(this.cmboTimberClass_TextChanged);
            // 
            // cmbodepth
            // 
            this.cmbodepth.FormattingEnabled = true;
            this.cmbodepth.Location = new System.Drawing.Point(281, 385);
            this.cmbodepth.Name = "cmbodepth";
            this.cmbodepth.Size = new System.Drawing.Size(61, 28);
            this.cmbodepth.TabIndex = 25;
            this.cmbodepth.Visible = false;
            this.cmbodepth.TextChanged += new System.EventHandler(this.cmbodepth_TextChanged);
            // 
            // cmbobreadth
            // 
            this.cmbobreadth.FormattingEnabled = true;
            this.cmbobreadth.Location = new System.Drawing.Point(446, 388);
            this.cmbobreadth.Name = "cmbobreadth";
            this.cmbobreadth.Size = new System.Drawing.Size(64, 28);
            this.cmbobreadth.TabIndex = 26;
            this.cmbobreadth.Visible = false;
            this.cmbobreadth.TextChanged += new System.EventHandler(this.cmbobreadth_TextChanged);
            // 
            // frmBeamCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1869, 1148);
            this.Controls.Add(this.cmbobreadth);
            this.Controls.Add(this.cmbodepth);
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
        private System.Windows.Forms.ComboBox cmbodepth;
        private System.Windows.Forms.ComboBox cmbobreadth;
    }
}

