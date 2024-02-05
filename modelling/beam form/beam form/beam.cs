using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beam_form
{
    internal class Beam
    {
        public decimal breadth { get; set; }
        public decimal depth { get; set; }
        public decimal length { get; set; }
        public decimal load { get; set; }
        public decimal modulusElasticity { get; set; }
        public decimal momentOfInertia { get; set; }
        public decimal stiffnessBeam { get; set; }

        public decimal beamDisplacement { get; set; }
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
        public decimal calcMaxTimberDeflection2D(string txtModulusElasticity, string depth, string breadth)
        {

            decimal timberMomentOfInertia = 0;
            int index = 0;
            #region finding index for inertia

            if (Convert.ToDecimal(depth) == 150)
                index += 5;
            if (Convert.ToDecimal(depth) == 175)
                index += 11;
            if (Convert.ToDecimal(depth) == 200)
                index += 15;
            if (Convert.ToDecimal(depth) == 225)
                index += 21;
            if (Convert.ToDecimal(depth) == 250)
                index += 26;

            if (Convert.ToDecimal(breadth) == 50)
                index += 1;
            if (Convert.ToDecimal(breadth) == 63)
                index += 2;
            if (Convert.ToDecimal(breadth) == 75)
                index += 3;
            if (Convert.ToDecimal(breadth) == 100)
                index += 4;
            if (Convert.ToDecimal(breadth) == 150)
                index += 5;
            #endregion
            SQLiteConnection conn = new SQLiteConnection("Data Source = materialstrproperties.db; Version = 3; New = True; Compress = True;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM timberdimensionproperties WHERE depth={depth} AND breadth={breadth}";
            SQLiteDataReader reader = cmd.ExecuteReader();
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    timberMomentOfInertia = Convert.ToDecimal(reader["areaMoment2ndIx"]);
                }
            }
            reader.Close();

            decimal MaxBeamDeflection = 0;

            decimal timberModulusElasticity = Convert.ToDecimal(txtModulusElasticity); // get from database depending on dimensions

             // NEED TO GET LISTS FROM DATABASE, you have the index and everything
                                               //decimal timberMomentOfInertia = sectionModulusZxList[index]    //uncomment when have list from database

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

    }
}
