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
            conn.Close();
        }
    }
}
