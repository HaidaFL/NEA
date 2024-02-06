using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beam_form
{
    internal class crossSectionBeam //with normal cross-section
    {
        decimal sectionModulus; // it is breadth times depth^2, all divided by 6

        decimal ReactionForceA;
        decimal ReactionForceB;

        public decimal CalculateUniBeamCustomDimensions(decimal load, decimal beamDisplacement, decimal length, decimal w)
        {
            decimal DeflectionA = 0;
            decimal DeflectionB = 0;
            decimal MaxDeflection = 0;
            ReactionForceB = (load*2*(beamDisplacement + (w/2) ))/10;
            ReactionForceA = (load*2*(length - beamDisplacement - (w/2)))/10;

            DeflectionA = (ReactionForceA * beamDisplacement);
            DeflectionB = (ReactionForceA * beamDisplacement) - (load *(power(length - (2 * beamDisplacement),2) )/2 );

            MaxDeflection = (ReactionForceA * (beamDisplacement + (w/2)) - (load * power(beamDisplacement + (w / 2), 2)) / 2);
            return 0;
        }
        public decimal CalculatePointBeamCustomDimensions(decimal load, decimal beamDisplacement, decimal length, decimal w, decimal forceAngle)
        {
            decimal MaxDeflection = 0;
            decimal forceAngleRad = (forceAngle * Convert.ToDecimal(Math.PI)) / 180;


            if (forceAngle == 90)
            {
                ReactionForceA = (load * (length - beamDisplacement)) / length;
                ReactionForceB = (load * beamDisplacement) / length;
                MaxDeflection = ReactionForceA * beamDisplacement;

                return MaxDeflection;
            }
            else
            {
                ReactionForceA = (load * (length - beamDisplacement) * Convert.ToDecimal(Math.Sin(Convert.ToDouble(forceAngleRad)))) / length;
                ReactionForceB = (load * beamDisplacement * Convert.ToDecimal(Math.Sin(Convert.ToDouble(forceAngleRad)))) / length;

                MaxDeflection = ReactionForceA * beamDisplacement;

                return MaxDeflection;
            }
        }
        public decimal CalculateSlopeBeamCustomDimensions(decimal load, decimal beamDisplacement, decimal length, decimal w, decimal s_load, decimal e_load)
        {
            decimal DeflectionA = 0;
            decimal DeflectionB = 0;
            decimal MaxDeflection = 0;

            ReactionForceB = (((e_load - s_load) * w) / 2) * (beamDisplacement + w - (w / 3)) + (s_load * w * (((beamDisplacement + w) - (w / 2)) / length));
            ReactionForceA = (((e_load - s_load) * w) / 2) * (length - (beamDisplacement + (w/3))) + (s_load * w * ((length - (beamDisplacement + (w / 3))) / length));

            DeflectionA = ReactionForceA;
            DeflectionB = DeflectionA;
            MaxDeflection = DeflectionB;

            return 0;
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
