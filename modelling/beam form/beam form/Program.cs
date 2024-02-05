using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace beam_form
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initialiseDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBeamCalculation());

        }
        static void initialiseDatabase()
        {
            
            SQLiteConnection conn = new SQLiteConnection("Data Source = materialstrproperties.db; Version = 3; New = True; Compress = True;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS timberstrproperties(Class varchar primary key, minME int, Tensionpg double, Bendingpg double, compressprlel double, compressprdclr double, shearpg double, density double)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT COUNT(*) FROM timberstrproperties";
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount == 0 )
            {
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C14', 4600,4.1,2.5,5.2,2.1,0.6,290)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C16',5800,5.3,3.2,6.8,2.2,0.67,310)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C18',6000,5.8,3.5,7.1,2.2,0.67,320)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C22',6500,6.8,4.1,7.5,2.3,0.71,340)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C24',7200,7.5,4.5,7.9,2.4,0.71,350)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('TR26',7400,10,6,8.2,2.5,1.1,37)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C27',8200,10,6,8.2,2.5,1.1,370)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C30',8200,11,6.6,8.6,2.7,1.2,380)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C35',9000,12,7.2,8.7,2.9,1.3,400)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberstrproperties VALUES ('C40',10000,13,7.8,8.7,3,1.4,420)";
                cmd.ExecuteNonQuery();

            }
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS timberdimensionproperties(depth double, breadth double, sectionModulusZx double, sectionModulusZy double, areaMoment2ndIx double, areaMoment2ndIy double)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT COUNT(*) FROM timberdimensionproperties";
            int rowCount2 = Convert.ToInt32(cmd.ExecuteScalar());
            if (rowCount2 == 0)
            {
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (100, 38, 63.3,24.1,3.17,0.46)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (100,50,83.3,41.7,4.17,1.04)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (100,63,105,66.2,5.25,2.08)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (100,75,125,93.8,6.25,3.52)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (100,100,166.7,166.7,8.33,8.33)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,38,142.5,36.1,10.69,0.69)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,50,187.5,62.5,14.06,1.56)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,63,236.3,99.2,17.72,3.13)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,75,281.3,14.6,21.09,5.27)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,100,375.0,250,28.13,12.5)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (150,150,562.5,562.5,42.19,42.19)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (175, 38,194,42.1,16.97,0.8)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (175,50,255.2,72.9,22.33,1.82)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (175,63,321.6,115.8,28.14,3.65)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (175,75,382.8,164.1,33.5,6.15)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,38,253.3,48.1,25.33,0.91)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,50,333.3,83.3,33.33,2.08)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,63,420,132.3,42,4.17)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,75,500,187.5,50,7.03)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,100,666.7,333.3,66.67,16.67)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (200,150,1000,750,100,56.25)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (225,38,320.6,54.2,36.07,1.03)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (225,50,421.9,93.8,47.46,2.34)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (225,63,531.6,148.8,59.8,4.69)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (225,75,632.8,210.9,71.19,7.91)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (225,100,843.8,375,94.92,18.75)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (250,38,395.8,60.2,49.48,1.14)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (250,50, 520.8,104.2,65.10,2.6)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (250,63,656.3,165.4,82.03,5.21)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (250,75,781.3,234.4,97.66,8.79)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO timberdimensionproperties VALUES (250,100,1041.7,416.7,130.21,20.83)";
                cmd.ExecuteNonQuery();
               

            }
        }
    }
}
