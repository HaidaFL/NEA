using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;



namespace beam_form
{
    public partial class frmBeamCalculation : Form
    {
        List<string> timbersC14 = new List<string>();
        List<string> timbersC16 = new List<string>();
        List<string> timbersC18 = new List<string>();
        List<string> timbersC22 = new List<string>();
        List<string> timbersTR26 = new List<string>();
        List<string> timbersC27 = new List<string>();
        List<string> timbersC30 = new List<string>();
        List<string> timbersC35 = new List<string>();
        List<string> timbersC40 = new List<string>();

        public frmBeamCalculation()
        {

            InitializeComponent();

            SQLiteConnection conn = new SQLiteConnection("Data Source = materialstrproperties.db; Version = 3; New = True; Compress = True;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            #region timber class strength lists

            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C14'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC14.Add(reader.GetString(0));
                System.Diagnostics.Debug.WriteLine(timbersC14[0]);
                timbersC14.Add(reader.GetInt32(1).ToString());
                timbersC14.Add(reader.GetDouble(2).ToString());
                timbersC14.Add(reader.GetDouble(3).ToString());
                timbersC14.Add(reader.GetDouble(4).ToString());
                timbersC14.Add(reader.GetDouble(5).ToString());
                timbersC14.Add(reader.GetDouble(6).ToString());
                timbersC14.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C16'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC16.Add(reader.GetString(0));
                timbersC16.Add(reader.GetInt32(1).ToString());
                timbersC16.Add(reader.GetDouble(2).ToString());
                timbersC16.Add(reader.GetDouble(3).ToString());
                timbersC16.Add(reader.GetDouble(4).ToString());
                timbersC16.Add(reader.GetDouble(5).ToString());
                timbersC16.Add(reader.GetDouble(6).ToString());
                timbersC16.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C18'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC18.Add(reader.GetString(0));
                timbersC18.Add(reader.GetInt32(1).ToString());
                timbersC18.Add(reader.GetDouble(2).ToString());
                timbersC18.Add(reader.GetDouble(3).ToString());
                timbersC18.Add(reader.GetDouble(4).ToString());
                timbersC18.Add(reader.GetDouble(5).ToString());
                timbersC18.Add(reader.GetDouble(6).ToString());
                timbersC18.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C22'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC22.Add(reader.GetString(0));
                timbersC22.Add(reader.GetInt32(1).ToString());
                timbersC22.Add(reader.GetDouble(2).ToString());
                timbersC22.Add(reader.GetDouble(3).ToString());
                timbersC22.Add(reader.GetDouble(4).ToString());
                timbersC22.Add(reader.GetDouble(5).ToString());
                timbersC22.Add(reader.GetDouble(6).ToString());
                timbersC22.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'TR26'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersTR26.Add(reader.GetString(0));
                timbersTR26.Add(reader.GetInt32(1).ToString());
                timbersTR26.Add(reader.GetDouble(2).ToString());
                timbersTR26.Add(reader.GetDouble(3).ToString());
                timbersTR26.Add(reader.GetDouble(4).ToString());
                timbersTR26.Add(reader.GetDouble(5).ToString());
                timbersTR26.Add(reader.GetDouble(6).ToString());
                timbersTR26.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C27'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC27.Add(reader.GetString(0));
                timbersC27.Add(reader.GetInt32(1).ToString());
                timbersC27.Add(reader.GetDouble(2).ToString());
                timbersC27.Add(reader.GetDouble(3).ToString());
                timbersC27.Add(reader.GetDouble(4).ToString());
                timbersC27.Add(reader.GetDouble(5).ToString());
                timbersC27.Add(reader.GetDouble(6).ToString());
                timbersC27.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C30'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC30.Add(reader.GetString(0));
                timbersC30.Add(reader.GetInt32(1).ToString());
                timbersC30.Add(reader.GetDouble(2).ToString());
                timbersC30.Add(reader.GetDouble(3).ToString());
                timbersC30.Add(reader.GetDouble(4).ToString());
                timbersC30.Add(reader.GetDouble(5).ToString());
                timbersC30.Add(reader.GetDouble(6).ToString());
                timbersC30.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C35'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC35.Add(reader.GetString(0));
                timbersC35.Add(reader.GetInt32(1).ToString());
                timbersC35.Add(reader.GetDouble(2).ToString());
                timbersC35.Add(reader.GetDouble(3).ToString());
                timbersC35.Add(reader.GetDouble(4).ToString());
                timbersC35.Add(reader.GetDouble(5).ToString());
                timbersC35.Add(reader.GetDouble(6).ToString());
                timbersC35.Add(reader.GetDouble(7).ToString());
            }
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberstrproperties WHERE class = 'C40'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                timbersC40.Add(reader.GetString(0));
                timbersC40.Add(reader.GetInt32(1).ToString());
                timbersC40.Add(reader.GetDouble(2).ToString());
                timbersC40.Add(reader.GetDouble(3).ToString());
                timbersC40.Add(reader.GetDouble(4).ToString());
                timbersC40.Add(reader.GetDouble(5).ToString());
                timbersC40.Add(reader.GetDouble(6).ToString());
                timbersC40.Add(reader.GetDouble(7).ToString());
            }
            #endregion
            cmboTimberClass.Items.Add(timbersC14[0]);
            cmboTimberClass.Items.Add(timbersC16[0]);
            cmboTimberClass.Items.Add(timbersC18[0]);
            cmboTimberClass.Items.Add(timbersC22[0]);
            cmboTimberClass.Items.Add(timbersTR26[0]);
            cmboTimberClass.Items.Add(timbersC27[0]);
            cmboTimberClass.Items.Add(timbersC30[0]);
            cmboTimberClass.Items.Add(timbersC35[0]);
            cmboTimberClass.Items.Add(timbersC40[0]);

            cmboTimberClass.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radUniformAreaForce_CheckedChanged(object sender, EventArgs e)
        {
            ClearText();
            cmboTimberClass.SelectedIndex = -1;

            cmboTimberClass.Enabled = false;

            txtModulusElasticity.Enabled = true;
            txtForceWidth.Enabled = true;
            txtbreadth.Enabled = false;
            txtdepth.Enabled = false;
        }
        private void radSinglePointForce_CheckedChanged(object sender, EventArgs e)
        {
            ClearText();
            cmboTimberClass.SelectedIndex = -1;

            cmboTimberClass.Enabled = false;

            txtModulusElasticity.Enabled = true;
            txtForceWidth.Enabled = false;
            txtbreadth.Enabled = false;
            txtdepth.Enabled = false;
        }

        private void radTimberBeamMD_CheckedChanged(object sender, EventArgs e)
        {
            ClearText();
            cmboTimberClass.SelectedIndex = -1;

            cmboTimberClass.Enabled = true;

            txtModulusElasticity.Enabled = false;
            txtbreadth.Enabled = true;
            txtdepth.Enabled = true;
        }

        private void frmBeamCalculation_Load(object sender, EventArgs e)
        {
            radUniformAreaForce.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculatebutton();

        }
        private void ClearText()
        {

            var TextBoxes = Controls.OfType<TextBox>();
            foreach (TextBox TextBox in TextBoxes)
            {
                TextBox.Clear();
            }

        }
        private void calculatebutton()
        {
            Beam o_beam = new Beam();

            if (txtlength.Text == "" || txtModulusElasticity.Text == "" || txtDisplacement.Text == "" || txtInertia.Text == "" || txtload.Text == "")
            {
                MessageBox.Show("fill all required values", "error : ");
                return;
            }
            if (radUniformAreaForce.Checked == true)
            {
                if (txtForceWidth.Text == "")
                {
                    MessageBox.Show("fill in force width", "error : ");
                    return;
                }
            }
            if (radTimberBeamMD.Checked == true)
            {
                if (txtdepth.Text == "")
                {
                    MessageBox.Show("fill in depth", "error : ");
                    return;
                }
                if (txtbreadth.Text == "")
                {
                    MessageBox.Show("fill in breadth", "error : ");
                    return;
                }
                o_beam.breadth = Convert.ToDecimal(txtbreadth.Text);
                o_beam.depth = Convert.ToDecimal(txtdepth.Text);
            }




            ArrayList al_vehicles = new ArrayList();

            o_beam.length = Convert.ToDecimal(txtlength.Text);
            o_beam.load = Convert.ToDecimal(txtload.Text);
            o_beam.modulusElasticity = Convert.ToDecimal(txtModulusElasticity.Text);
            o_beam.momentOfInertia = Convert.ToDecimal(txtInertia.Text);
            o_beam.beamDisplacement = Convert.ToDecimal(txtDisplacement.Text);

            if (o_beam.beamDisplacement > o_beam.length)
            {
                MessageBox.Show("beam displacement is larger than length", "error : ");
                return;
            }
            decimal GraphDisplacement = 0;
            if (radUniformAreaForce.Checked == true)
            {

                decimal w = Convert.ToDecimal(txtForceWidth.Text);

                if ((w + o_beam.beamDisplacement) > o_beam.length)
                {
                    MessageBox.Show("length is too small", "error : ");

                    return;
                }
                txtMaxDeflection.Text = o_beam.calcUniformAreaDeflection2D(w).ToString();
                GraphDisplacement = o_beam.beamDisplacement + (w / 2);

            }

            if (radSinglePointForce.Checked == true)
            {
                txtMaxDeflection.Text = o_beam.calcMaxBeamDeflection2D().ToString();
                GraphDisplacement = o_beam.beamDisplacement;
            }

            if (radUniformAreaForce.Checked == true)
            {
                txtMaxDeflection.Text = o_beam.calcMaxTimberDeflection2D().ToString();

            }

            // Clear any existing series

            chrtDeflectionGraph.Series.Clear();

            chrtDeflectionGraph.ChartAreas[0].AxisX.Maximum = Double.NaN;
            chrtDeflectionGraph.ChartAreas[0].AxisX.Minimum = Double.NaN;
            chrtDeflectionGraph.ChartAreas[0].AxisY.Maximum = Double.NaN;
            chrtDeflectionGraph.ChartAreas[0].AxisY.Minimum = Double.NaN;
            // Add a new series
            Series series = new Series("Data Series");

            // Set the chart type to a line series with a spline interpolation
            series.ChartType = SeriesChartType.Spline;


            // Add data points to the series
            series.Points.AddXY(0, 0);
            series.Points.AddXY(GraphDisplacement, -Convert.ToDecimal(txtMaxDeflection.Text));
            series.Points.AddXY(o_beam.length, 0);

            // Add the series to the chart
            chrtDeflectionGraph.Series.Add(series);

            // Customize the chart appearance as needed
            chrtDeflectionGraph.ChartAreas[0].AxisX.Title = "X-Axis";
            chrtDeflectionGraph.ChartAreas[0].AxisY.Title = "Y-Axis";
        }
        private void txtlength_TextChanged(object sender, EventArgs e)
        {

        }

        #region validate numeric inputs
        private void txtlength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtload_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtModulusElasticity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtInertia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtDisplacement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtForceWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }

        private void txtMaxDeflection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) { e.Handled = true; }
        }
        #endregion

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculatebutton();
            }
        }

        private void cmboTimberClass_TextChanged(object sender, EventArgs e)
        {
            switch (cmboTimberClass.Text)
            {
                case ("C14"):
                    txtModulusElasticity.Text = timbersC14[1];
                    break;
                case ("C16"):
                    txtModulusElasticity.Text = timbersC16[1];
                    break;
                case ("C18"):
                    txtModulusElasticity.Text = timbersC18[1];
                    break;
                case ("C22"):
                    txtModulusElasticity.Text = timbersC22[1];
                    break;
                case ("TR26"):
                    txtModulusElasticity.Text = timbersTR26[1];
                    break;
                case ("C27"):
                    txtModulusElasticity.Text = timbersC27[1];
                    break;
                case ("C30"):
                    txtModulusElasticity.Text = timbersC30[1];
                    break;
                case ("C35"):
                    txtModulusElasticity.Text = timbersC35[1];
                    break;
                case ("C40"):
                    txtModulusElasticity.Text = timbersC40[1];
                    break;

            }
        }
        #region
        //decimal calcCarDeflection(Beam o_beam)
        //{
        //    int carNumber = 1;
        //    decimal carLength = 5;
        //    decimal maxDeflection = 0;




        //    return maxDeflection;
        //}
        //class Vehicle //databases of cars for future enhancements
        //{
        //    int vehicleIndex { get; set; }
        //    decimal vehicleWeight { get; set; }


        //}
        #endregion
        class Beam
        {
            public decimal breadth { get; set; }
            public decimal depth { get; set; }
            public decimal length { get; set; }
            public decimal load { get; set; }
            public decimal modulusElasticity { get; set; }
            public decimal momentOfInertia { get; set; }
            public decimal stiffnessBeam { get; set; }

            public decimal beamDisplacement { get; set; }

            public decimal calcUniformAreaDeflection2D(decimal w)
            {
                decimal MaxDeflection = 0;
                decimal DisplacementEndPoint = beamDisplacement;
                if ((beamDisplacement + w / 2) > (length / 2))
                {
                    DisplacementEndPoint = length - (w + beamDisplacement);
                }


                if (w < length)
                {
                    MaxDeflection = w / (384 * modulusElasticity * momentOfInertia);
                    MaxDeflection = MaxDeflection * ((8 * power(length, 3)) - (4 * length * power(DisplacementEndPoint, 2)) + power(DisplacementEndPoint, 3));

                    return MaxDeflection;
                }
                if (w == length)
                {
                    decimal numerator = 5 * w * power(length, 4);
                    decimal denominator = 384 * modulusElasticity * momentOfInertia;
                    MaxDeflection = numerator / denominator;

                    return MaxDeflection;
                }


                return 0;

            }
            public decimal calcMaxTimberDeflection2D()
            {
                decimal MaxBeamDeflection = 0;

                decimal timberModulusElasticity = 1; // get from database depending on dimensions

                decimal timberMomentOfInertia = 1; // get from database depending on dimensions


                decimal numerator = load * power(length, 3);
                decimal denominator = 48 * timberModulusElasticity * timberMomentOfInertia;
                MaxBeamDeflection = numerator / denominator;
                return MaxBeamDeflection;
            }

            public decimal calcMaxBeamDeflection2D() //simply supported 
            {

                decimal DisplacementEndPoint = beamDisplacement;
                if (beamDisplacement > (length / 2))
                {
                    DisplacementEndPoint = length - beamDisplacement;
                }

                decimal numerator = (load * DisplacementEndPoint) * (3 * power(length, 2) - 4 * power(DisplacementEndPoint, 2));
                decimal denominator = (48 * modulusElasticity * momentOfInertia);

                decimal deflection = numerator / denominator; //in meters

                Console.WriteLine("deflection in millimeters");


                return decimal.Round(100 * deflection, 2);
            }
            public decimal power(decimal value, int power)
            {
                if (power == 0)
                {
                    return 1;
                }
                if (power > 0)
                {
                    for (int i = 1; i < power; i++)
                    {
                        value *= value;
                    }
                }
                else
                {
                    for (int i = 1; i < -power; i++)
                    {
                        value *= value;
                    }
                    value = 1 / value;
                }



                return value;
            }
        }
    }
        
    

}
