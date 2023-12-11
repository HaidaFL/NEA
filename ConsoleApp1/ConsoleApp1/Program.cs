using System;
using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


//TARGETS: 1)redo co-ordinate system and make it out of floats, doesnt work otherwise 2) then put the youngs modulus bit in there w forces properly


public class AddCoordinates
{
    public static void AddPositiveCoordinates(List<(double x, double y, double z)> list, double x, double y, double z)
    {

        if (x >= 0 && y >= 0 && z >= 0)
        {
            list.Add(( x, y, z));
        }
        else
        {
            Console.WriteLine($"Invalid coordinates: X={x}, Y={y}, Z={z}. Coordinates must be positive.");
        }
    }
}
public class Force
{
    public float g = 9.81f;
    public Tuple<double, double, double> XYZforce { get; set; }

    public Force(Tuple<double, double, double> xyzforce)
    { XYZforce = xyzforce; }
    public double ReactionForce(float mass, float XYZforce)
    {
        return ((mass * g) + XYZforce);
    }
}
public class PhysicsObject
{
    // Properties
    public float Mass { get; protected set; }
    public float Velocity { get; protected set; }
    public float YoungsModulus { get; protected set; }
    public float Deformation { get; protected set; }
    public float MaxDeformation { get; protected set; }
    public double GroundLevel { get; protected set; }
    public float Area { get; protected set; }
    public float ForceToStayAboveGround { get; protected set; }

    public bool AtGround { get; protected set; }
    // Constructor
    public PhysicsObject(float mass, float initialVelocity, float youngsModulus, float maxDeformation, double groundLevel, float area, bool atGround)
    {
        Mass = mass;
        Velocity = initialVelocity;
        YoungsModulus = youngsModulus;
        Deformation = 0.0f;
        MaxDeformation = maxDeformation;
        GroundLevel = groundLevel;
        Area = area;
        AtGround = atGround;
    }

    // Update method to simulate physics over time
    public void Update(float deltaTime, float appliedForce)
    {
        float acceleration = appliedForce / Mass;
        Velocity += acceleration * deltaTime;

        double newY = (double)(GroundLevel + Deformation * Area); // calculate the new Y-coordinate based on the ground level and deformation

        // calculate deformation, this doesnt even work in this situation anymore, i need to adjust so much further
        float stress = appliedForce / Area;
        Deformation = stress / YoungsModulus;

        // check if the object is below the ground level
        if (newY < GroundLevel) //checks if object is very slightly below ground level
        {
            float forceToResistGravity = appliedForce;
            float accelerationToStayAboveGround = -(forceToResistGravity / Mass);
            Velocity = 0;
            stress = (2 * appliedForce) / Area;
            Deformation = stress / YoungsModulus;
            AtGround = true;
        }

        Console.WriteLine($"Time: {DateTime.Now}, Applied Force: {appliedForce}, Deformation: {Deformation}, Velocity: {Velocity}");

        // Check for failure based on deformation threshold and velocity
        if (Deformation > MaxDeformation || Velocity > 0)
        {
            Console.WriteLine("Object has failed!");
            // then we need to get all the details of the objects failure, where and how and why
        }
    }
}

class Program
{
    static void Main()
    {
        // Creating a list to store 3D coordinates
        List<(double x, double y, double z)> coordinatesList = new();

        Console.WriteLine("Enter x y z:");

        // Reading input and converting to doubleegers using double.TryParse
        double x, y, z;
        if (double.TryParse(Console.ReadLine(), out x) &&
            double.TryParse(Console.ReadLine(), out y) &&
            double.TryParse(Console.ReadLine(), out z))
        {
            AddCoordinates.AddPositiveCoordinates(coordinatesList, x, y, z);

            float area = 1.0f; // Assuming the cross-sectional area is 1 unit, adjust based on your object's geometry
            PhysicsObject buildingBlock = new PhysicsObject(1.0f, 0.0f, 1.0f, 0.1f, 0, area, false); // Assuming ground level is at Y=0
            Console.WriteLine("Enter x y z:");
            double xyz = tuple
            // Simulate physics with an applied force
            for (double i = 0; i < 10; i++)
            {
                buildingBlock.Update(0.1f, 50.0f, ); // Assuming a small time step of 0.1 seconds and a force of 50 Newtons
                                                     // Displaying the coordinates in the list
                Console.WriteLine("Stored Coordinates:");
                foreach (var coordinates in coordinatesList)
                {
                    Console.WriteLine($"X: {coordinates.x}, Y: {coordinates.y}, Z: {coordinates.z}");
                }
            }


        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid doublegers for x, y, and z.");
        }
    }
}