using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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

        List<double> depthList = new List<double>();
        List<double> breadthList = new List<double>();
        List<double> sectionModulusZxList = new List<double>();
        List<double> sectionModulusZyList = new List<double>();
        List<double> areaMoment2ndIxList = new List<double>();
        List<double> areaMoment2ndIyList = new List<double>();

        #region manual list code (outdated manual code) to be ignored
        List<double> D_hundredList = new List<double>();
        List<double> D_oneFiftyList = new List<double>();
        List<double> D_oneSevenFiveList = new List<double>();
        List<double> D_twoHundredList = new List<double>();
        List<double> D_twoTwoFiveList = new List<double>();
        List<double> D_twoFiftyList = new List<double>();


        List<double> B_threeEightList = new List<double>();
        List<double> B_fiftyList = new List<double>();
        List<double> B_sixtyThreeList = new List<double>();
        List<double> B_seventyFiveList = new List<double>();
        List<double> B_hundredList = new List<double>();
        List<double> B_oneFiftyList = new List<double>();
        #endregion
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
            #region adding class strength timber to cmbo box
            cmboTimberClass.Items.Add(timbersC14[0]);
            cmboTimberClass.Items.Add(timbersC16[0]);
            cmboTimberClass.Items.Add(timbersC18[0]);
            cmboTimberClass.Items.Add(timbersC22[0]);
            cmboTimberClass.Items.Add(timbersTR26[0]);
            cmboTimberClass.Items.Add(timbersC27[0]);
            cmboTimberClass.Items.Add(timbersC30[0]);
            cmboTimberClass.Items.Add(timbersC35[0]);
            cmboTimberClass.Items.Add(timbersC40[0]);
            #endregion
            
            reader.Close();
            cmd.CommandText = "SELECT * FROM timberdimensionproperties";
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    depthList.Add(Convert.ToDouble(reader["depth"]));
                    breadthList.Add(Convert.ToDouble(reader["breadth"]));
                    sectionModulusZxList.Add(Convert.ToDouble(reader["sectionModulusZx"]));
                    sectionModulusZyList.Add(Convert.ToDouble(reader["sectionModulusZy"]));
                    areaMoment2ndIxList.Add(Convert.ToDouble(reader["areaMoment2ndIx"]));
                    areaMoment2ndIyList.Add(Convert.ToDouble(reader["areaMoment2ndIy"]));
                }
            }
            reader.Close();
            #region timber dimension properties list
            //depthList.Add(100);
            //depthList.Add(100);
            //depthList.Add(100);
            //depthList.Add(100);
            //depthList.Add(100);


            //depthList.Add(150);
            //depthList.Add(150);
            //depthList.Add(150);
            //depthList.Add(150);
            //depthList.Add(150);
            //depthList.Add(150);


            //depthList.Add(175);
            //depthList.Add(175);
            //depthList.Add(175);
            //depthList.Add(175);


            //depthList.Add(200);
            //depthList.Add(200);
            //depthList.Add(200);
            //depthList.Add(200);
            //depthList.Add(200);
            //depthList.Add(200);

            //depthList.Add(225);
            //depthList.Add(225);
            //depthList.Add(225);
            //depthList.Add(225);
            //depthList.Add(225);

            //depthList.Add(250);
            //depthList.Add(250);
            //depthList.Add(250);
            //depthList.Add(250);
            //depthList.Add(250);
            // // split
            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);
            //breadthList.Add(100);

            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);
            //breadthList.Add(100);
            //breadthList.Add(150);

            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);

            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);
            //breadthList.Add(100);
            //breadthList.Add(150);

            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);
            //breadthList.Add(100);

            //breadthList.Add(38);
            //breadthList.Add(50);
            //breadthList.Add(63);
            //breadthList.Add(75);
            //breadthList.Add(100);


            #endregion
            #region default timber drop-downs

            double latestDepth = 0;
            for (int i = 0;i < depthList.Count; i++)
            {
                if (latestDepth != depthList[i])
                {
                    cmbodepth.Items.Add(depthList[i]); //100
                }
                latestDepth = depthList[i];
            }
            cmd.CommandText = "SELECT distinct breadth FROM timberdimensionproperties ORDER BY breadth";
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbobreadth.Items.Add(Convert.ToDouble(reader["breadth"]));
                    
                }
            }
            reader.Close();
            #region outdated sort (maybe can be used to verify) do with chachu
            //breadthList.Sort(); 
            //double latestBreadth = 0;
            //for (int i = 0; i < breadthList.Count; i++)
            //{
            //    if (latestBreadth != breadthList[i])
            //    {
            //        cmbobreadth.Items.Add(breadthList[i]); //100
            //    }
            //    latestBreadth = breadthList[i];
            //}
            //depthList.Distinct();
            //cmbodepth.Items.Add(depthList[0]); //100
            //cmbodepth.Items.Add(depthList[5]); //150
            //cmbodepth.Items.Add(depthList[11]);  //175
            //cmbodepth.Items.Add(depthList[15]);  //200
            //cmbodepth.Items.Add(depthList[21]);  //225
            //cmbodepth.Items.Add(depthList[26]);  //250

            //cmbobreadth.Items.Add(breadthList[0]);
            //cmbobreadth.Items.Add(breadthList[1]);
            //cmbobreadth.Items.Add(breadthList[2]);
            //cmbobreadth.Items.Add(breadthList[3]);
            //cmbobreadth.Items.Add(breadthList[4]);
            //cmbobreadth.Items.Add(breadthList[10]);
            #endregion
            #endregion
            #region depth compatibility lists for TIMBER (outdated manual code)
            for (int i = 0; i < 6; i++) {
                if (i < 4) {

                    D_hundredList.Add(breadthList[i]);
                    D_oneFiftyList.Add(breadthList[i]);
                    D_oneSevenFiveList.Add(breadthList[i]);
                    D_twoHundredList.Add(breadthList[i]);
                    D_twoTwoFiveList.Add(breadthList[i]);
                    D_twoFiftyList.Add(breadthList[i]);

                }
                if (i == 4) {

                    D_hundredList.Add(breadthList[i]);
                    D_oneFiftyList.Add(breadthList[i]);
                    D_twoHundredList.Add(breadthList[i]);
                    D_twoTwoFiveList.Add(breadthList[i]);
                    D_twoFiftyList.Add(breadthList[i]);
                }
                if (i == 5)
                {
                    D_oneFiftyList.Add(breadthList[10]);
                    D_twoHundredList.Add(breadthList[10]);
                }
            }
            #endregion
            #region breadth compatibility lists for TIMBER (outdated manual code)
            B_threeEightList.Add(depthList[1]);
            B_fiftyList.Add(depthList[1]);
            B_sixtyThreeList.Add(depthList[1]);
            B_seventyFiveList.Add(depthList[1]);
            B_hundredList.Add(depthList[1]);

            B_threeEightList.Add(depthList[5]);
            B_fiftyList.Add(depthList[5]);
            B_sixtyThreeList.Add(depthList[5]);
            B_seventyFiveList.Add(depthList[5]);
            B_hundredList.Add(depthList[5]);
            B_oneFiftyList.Add(depthList[5]);

            B_threeEightList.Add(depthList[11]);
            B_fiftyList.Add(depthList[11]);
            B_sixtyThreeList.Add(depthList[11]);
            B_seventyFiveList.Add(depthList[11]);

            B_threeEightList.Add(depthList[15]);
            B_fiftyList.Add(depthList[15]);
            B_sixtyThreeList.Add(depthList[15]);
            B_seventyFiveList.Add(depthList[15]);
            B_hundredList.Add(depthList[15]);
            B_oneFiftyList.Add(depthList[15]);

            B_threeEightList.Add(depthList[21]);
            B_fiftyList.Add(depthList[21]);
            B_sixtyThreeList.Add(depthList[21]);
            B_seventyFiveList.Add(depthList[21]);
            B_hundredList.Add(depthList[21]);

            B_threeEightList.Add(depthList[26]);
            B_fiftyList.Add(depthList[26]);
            B_sixtyThreeList.Add(depthList[26]);
            B_seventyFiveList.Add(depthList[26]);
            B_hundredList.Add(depthList[26]);
            #endregion

            cmboTimberClass.DropDownStyle = ComboBoxStyle.DropDownList; //you cant type in the cmbo box because of this
            cmboTimberCalcs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboTimberCalcs.Items.Add("variable distance/angle single point force - StressTest");
            cmboTimberCalcs.Items.Add("variable distance uniform force - StressTest");
            cmboTimberCalcs.Items.Add("variable distance sloped uniform force - StressTest");
        }
        private void verifyList(List<double> dimension)
        {
            dimension.Distinct();  // DO THIS WITH CHACHU WHEN WAKUP
        }
        public void setInertia(decimal depth, decimal breadth)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source = materialstrproperties.db; Version = 3; New = True; Compress = True;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM timberdimensionproperties WHERE depth={depth} AND breadth={breadth}";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtInertia.Text = Convert.ToString(reader["areaMoment2ndIx"]);
            }
            reader.Close();
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
            cmboTimberCalcs.SelectedIndex = -1;

            cmboTimberClass.Enabled = false;
            cmboTimberCalcs.Enabled = false;

            txtModulusElasticity.Enabled = true;
            txtForceWidth.Enabled = true;

            txtbreadth.Enabled = false;
            txtdepth.Enabled = false;

            cmbobreadth.Visible = false;
            cmbodepth.Visible = false;

            txtbreadth.Visible = true;
            txtdepth.Visible = true;
        }
        private void radSinglePointForce_CheckedChanged(object sender, EventArgs e)
        {
            ClearText();
            cmboTimberClass.SelectedIndex = -1;
            cmboTimberCalcs.SelectedIndex = -1;

            cmboTimberClass.Enabled = false;
            cmboTimberCalcs.Enabled = false;

            txtModulusElasticity.Enabled = true;
            txtForceWidth.Enabled = false;

            txtbreadth.Visible = true;
            txtdepth.Visible = true;

            cmbobreadth.Visible = false;
            cmbodepth.Visible = false;

            txtbreadth.Enabled = false;
            txtdepth.Enabled = false;
        }

        private void radTimberBeamMD_CheckedChanged(object sender, EventArgs e)
        {
            ClearText();
            cmboTimberClass.SelectedIndex = -1;
            cmboTimberCalcs.SelectedIndex = -1;

            cmboTimberClass.Enabled = true;
            cmboTimberCalcs.Enabled = true;

            txtModulusElasticity.Enabled = false;

            txtbreadth.Visible = false;
            txtdepth.Visible = false;

            cmbobreadth.Visible = true;
            cmbodepth.Visible = true;

            txtbreadth.Enabled = true;
            txtdepth.Enabled = true;
        }
        #region node traversal lmao
        private void cmbobreadth_TextChanged(object sender, EventArgs e)
        {
            cmbodepth.Items.Clear();
            for (int i = 0; i < depthList.Count; i++)
            {
                if (breadthList[i] == Convert.ToDouble(cmbobreadth.Text))
                {
                    cmbodepth.Items.Add(depthList[i]);

                }
            }
            if (cmbodepth.Text != "")
            {
                setInertia(Convert.ToDecimal(cmbodepth.Text), Convert.ToDecimal(cmbobreadth.Text));
            }
            //switch (cmbobreadth.Text)
            //{
            //    case ("38"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_threeEightList.Count; i++)
            //            cmbodepth.Items.Add(B_threeEightList[i]);
            //    break;
            //    case ("50"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_fiftyList.Count; i++)
            //            cmbodepth.Items.Add(B_fiftyList[i]);
            //    break;
            //    case ("63"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_sixtyThreeList.Count; i++)
            //            cmbodepth.Items.Add(B_sixtyThreeList[i]);
            //    break;
            //    case ("75"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_seventyFiveList.Count; i++)
            //            cmbodepth.Items.Add(B_seventyFiveList[i]);
            //    break;
            //    case ("100"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_hundredList.Count; i++)
            //            cmbodepth.Items.Add(B_hundredList[i]);
            //    break;
            //    case ("150"):
            //        cmbodepth.Items.Clear();
            //       for (int i = 0; i < B_oneFiftyList.Count; i++)
            //            cmbodepth.Items.Add(B_oneFiftyList[i]);
            //    break;

            //}
        }
      
     
        private void cmbodepth_TextChanged(object sender, EventArgs e)
        {
            cmbobreadth.Items.Clear();
            for (int i = 0; i < breadthList.Count; i++)
            {
                if (depthList[i] == Convert.ToDouble(cmbodepth.Text))
                {
                    cmbobreadth.Items.Add(breadthList[i]);

                }
            }
            if (cmbobreadth.Text != "")
            {
                setInertia(Convert.ToDecimal(cmbodepth.Text), Convert.ToDecimal(cmbobreadth.Text));
            }
            #region manual bologne
            //switch (cmbodepth.Text)
            //{
            //    case ("100"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_hundredList.Count; i++)
            //            cmbobreadth.Items.Add(D_hundredList[i]);
            //        break;
            //    case ("150"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_oneFiftyList.Count; i++)
            //            cmbobreadth.Items.Add(D_oneFiftyList[i]);
            //        break;
            //    case ("175"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_oneSevenFiveList.Count; i++)
            //            cmbobreadth.Items.Add(D_oneSevenFiveList[i]);
            //        break;
            //    case ("200"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_twoHundredList.Count; i++)
            //            cmbobreadth.Items.Add(D_twoHundredList[i]);
            //        break;
            //    case ("225"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_twoTwoFiveList.Count; i++)
            //            cmbobreadth.Items.Add(D_twoTwoFiveList[i]);
            //        break;
            //    case ("250"):
            //        cmbobreadth.Items.Clear();
            //        for (int i = 0; i < D_twoFiftyList.Count; i++)
            //            cmbobreadth.Items.Add(D_twoFiftyList[i]);
            //        break;

            //}
            #endregion
        }
        #endregion

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
            crossSectionBeam o_crossSectionBeam = new crossSectionBeam();
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
                if (cmbodepth.Text == "")
                {
                    MessageBox.Show("fill in depth", "error : ");
                    return;
                }
                if (cmbobreadth.Text == "")
                {
                    MessageBox.Show("fill in breadth", "error : ");
                    return;
                }
                o_beam.breadth = Convert.ToDecimal(cmbobreadth.Text);
                o_beam.depth = Convert.ToDecimal(cmbodepth.Text);
            }


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

            if (radTimberBeamMD.Checked == true)
            {
                if (cmboTimberCalcs.Text == "")
                {
                    txtMaxDeflection.Text = o_beam.calcMaxTimberDeflection2D(txtModulusElasticity.Text, cmbobreadth.Text, cmbodepth.Text).ToString();
                    GraphDisplacement = (Convert.ToDecimal(0.5) * o_beam.length);
                }
                if (cmboTimberCalcs.Text == "variable distance/angle single point force - StressTest")
                {
                    txtMaxDeflection.Text = o_crossSectionBeam.CalculatePointBeamCustomDimensions(txtload, txtDisplacement, txtlength, txtForceWidth,  ).ToString;
                }
                if (cmboTimberCalcs.Text == "variable distance uniform force - StressTest")
                {

                }
                if (cmboTimberCalcs.Text == "variable distance sloped uniform force - StressTest")
                {

                }

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
        

        
    }
        
    

}
