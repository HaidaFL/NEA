using System;
using System.Collections.Generic;


//TARGETS: 1)redo co-ordinate system and make it out of floats, doesnt work otherwise 2) then put the youngs modulus bit in there w forces properly


public class AddCoordinates
{
    public static void AddPositiveCoordinates(List<Tuple<int, int, int>> list, int x, int y, int z)
    {

        if (x >= 0 && y >= 0 && z >= 0)
        {
            list.Add(new Tuple<int, int, int>(x, y, z));
        }
        else
        {
            Console.WriteLine($"Invalid coordinates: X={x}, Y={y}, Z={z}. Coordinates must be positive.");
        }
    }
}

public class PhysicsObject
{
    // Properties
    public float Mass { get; private set; }
    public float Velocity { get; private set; }
    public float YoungsModulus { get; private set; }
    public float Deformation { get; private set; }
    public float MaxDeformation { get; private set; }
    public int GroundLevel { get; private set; }
    public float Area { get; private set; }
    public float ForceToStayAboveGround { get; private set; }

    // Constructor
    public PhysicsObject(float mass, float initialVelocity, float youngsModulus, float maxDeformation, int groundLevel, float area, float forceToStayAboveGround)
    {
        Mass = mass;
        Velocity = initialVelocity;
        YoungsModulus = youngsModulus;
        Deformation = 0.0f;
        MaxDeformation = maxDeformation;
        GroundLevel = groundLevel;
        Area = area;
        ForceToStayAboveGround = forceToStayAboveGround;
    }

    // Update method to simulate physics over time
    public void Update(float deltaTime, float appliedForce)
    {
        float acceleration = appliedForce / Mass;
        Velocity += acceleration * deltaTime;

        int newY = (int)(GroundLevel + Deformation * Area); // calculate the new Y-coordinate based on the ground level and deformation



        // check if the object is below the ground level
        if (newY =< GroundLevel)
        {
            float forceToResistGravity = ForceToStayAboveGround - appliedForce;
            float accelerationToStayAboveGround = forceToResistGravity / Mass;
            Velocity += accelerationToStayAboveGround * deltaTime;
        }

        // calculate deformation, this doesnt even work in this situation anymore, i need to adjust so much further
        float stress = appliedForce / Area;
        Deformation = stress / YoungsModulus;

        Console.WriteLine($"Time: {DateTime.Now}, Applied Force: {appliedForce}, Deformation: {Deformation}, Velocity: {Velocity}");

        // Check for failure based on deformation threshold and velocity
        if (Deformation > MaxDeformation && Velocity > 0)
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
        List<Tuple<int, int, int>> coordinatesList = new List<Tuple<int, int, int>>();

        Console.WriteLine("Enter x y z:");

        // Reading input and converting to integers using int.TryParse
        int x, y, z;
        if (int.TryParse(Console.ReadLine(), out x) &&
            int.TryParse(Console.ReadLine(), out y) &&
            int.TryParse(Console.ReadLine(), out z))
        {
            AddCoordinates.AddPositiveCoordinates(coordinatesList, x, y, z);

            float area = 1.0f; // Assuming the cross-sectional area is 1 unit, adjust based on your object's geometry
            float forceToStayAboveGround = 10.0f; // Adjust as needed for the force required to stay above the ground
            PhysicsObject buildingBlock = new PhysicsObject(1.0f, 0.0f, 1.0f, 0.1f, 0, area, forceToStayAboveGround); // Assuming ground level is at Y=0

            // Simulate physics with an applied force
            for (int i = 0; i < 10; i++)
            {
                buildingBlock.Update(0.1f, 50.0f); // Assuming a small time step of 0.1 seconds and a force of 50 Newtons
            }

            // Displaying the coordinates in the list
            Console.WriteLine("Stored Coordinates:");
            foreach (var coordinates in coordinatesList)
            {
                Console.WriteLine($"X: {coordinates.Item1}, Y: {coordinates.Item2}, Z: {coordinates.Item3}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integers for x, y, and z.");
        }
    }
}
