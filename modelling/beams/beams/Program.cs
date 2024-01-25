using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Security.Authentication.ExtendedProtection;

main();



static void main()
{
    //Vehicle o_vehicle = new Vehicle();
    Beam o_beam = new Beam();
    ArrayList al_vehicles = new ArrayList();

    Console.WriteLine("enter length (m) : ");
    o_beam.length = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("enter load (kN) : ");
    o_beam.load = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("enter Modulus of Elasticity (kN/m^2) : ");
    o_beam.modulusElasticity = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("enter Moment of Inertia (m^4) : ");
    o_beam.momentOfInertia = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("enter Displacement along Beam left to right (m) : ");
    o_beam.beamDisplacement = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("what do you wanna calculate");
    Console.WriteLine("2Dmaxbeamdeflection");
    Console.WriteLine("2Duniformareadeflection");
    string input = Console.ReadLine();
    switch(input) 
        {
        case "2Dmaxbeamdeflection":
            Console.WriteLine(o_beam.calcMaxBeamDeflection2D());
            break;
        case "2Duniformareadeflection":
            Console.WriteLine("enter width of uniform force");
            decimal w = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(o_beam.calcUniformAreaDeflection2D(w));
            break;
    }
    
}
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

class Beam
{
    public decimal width { get; set; }
    public decimal height { get; set; }
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
        if ((beamDisplacement + w/2) > (length / 2))
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
    public decimal calcMaxBeamDeflection2D() //simply supported 
    {
       
        decimal DisplacementEndPoint = beamDisplacement;
        if (beamDisplacement > (length / 2))
        {
            DisplacementEndPoint = length - beamDisplacement;
        }

        decimal numerator = (load * DisplacementEndPoint) * (3 * power(length, 2) - 4 * power(DisplacementEndPoint, 2)) ;
        decimal denominator = (48 * modulusElasticity * momentOfInertia);

                  decimal deflection = numerator / denominator; //in meters

        Console.WriteLine("deflection in millimeters");


                   return decimal.Round(100*deflection, 2);
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


