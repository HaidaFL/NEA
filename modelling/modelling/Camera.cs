using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelling
{
    internal class Camera
    {/*
        float width;
        float height;
        int planeview;
        string projectionmatrix = @"
         #version 330 core
         layout (location = 0) in vec3 aPos;
         ...
         uniform mat4 model;
         uniform mat4 view;
         uniform mat4 projection;

         void main()
        {
         // note that we read the multiplication from right to left
         gl_Position =  vec4(aPos, 1.0) * model * view * projection;
         ...
        }";
        public Camera() { }
        void persepective()
        {
            Matrix4.CreateOrthographicOffCenter(0.0f, 800.0f, 0.0f, 600.0f, 0.1f, 100.0f);
            Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), (float)width / (float)height, 0.1f, 100.0f);
            Matrix4 model = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-55.0f));
            // Note that we're translating the scene in the reverse direction of where we want to move.
            Matrix4 view = Matrix4.CreateTranslation(0.0f, 0.0f, -3.0f);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), width / height, 0.1f, 100.0f);

            planeview = CreateProgram(planeview, projection);

            shader.SetMatrix4("model", model);
            shader.SetMatrix4("view", view);
            shader.SetMatrix4("projection", projection);
        }*/
    }
}
