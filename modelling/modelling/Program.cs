using OpenTK.Compute.OpenCL;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System;


//TEXTURES AND THE POINTERS ARE SO FUCKED
using (Game game = new Game(800, 600, "hello"))
{

    game.Run();

}

    public class Game : GameWindow
    {

    float width;

    float height;

        int time;

        int vertexArrayObject_S;//standard vao

        int vertexArrayObject_T;//texture vao

        int vertexBufferObject;

        int elementBufferObject;

        int handle;  //shader thingy, can put in a shader class for organisation later if i want
        int texHandle;

    // int vertexBufferArray;

    float[] vertices = {
    -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,
     0.5f, -0.5f, -0.5f,  1.0f, 0.0f,
     0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
     0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
    -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
    -0.5f, -0.5f, -0.5f,  0.0f, 0.0f,

    -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
     0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
     0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
     0.5f,  0.5f,  0.5f,  1.0f, 1.0f,
    -0.5f,  0.5f,  0.5f,  0.0f, 1.0f,
    -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,

    -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
    -0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
    -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
    -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
    -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
    -0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

     0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
     0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
     0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
     0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
     0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
     0.5f,  0.5f,  0.5f,  1.0f, 0.0f,

    -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,
     0.5f, -0.5f, -0.5f,  1.0f, 1.0f,
     0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
     0.5f, -0.5f,  0.5f,  1.0f, 0.0f,
    -0.5f, -0.5f,  0.5f,  0.0f, 0.0f,
    -0.5f, -0.5f, -0.5f,  0.0f, 1.0f,

    -0.5f,  0.5f, -0.5f,  0.0f, 1.0f,
     0.5f,  0.5f, -0.5f,  1.0f, 1.0f,
     0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
     0.5f,  0.5f,  0.5f,  1.0f, 0.0f,
    -0.5f,  0.5f,  0.5f,  0.0f, 0.0f,
    -0.5f,  0.5f, -0.5f,  0.0f, 1.0f
};
    uint[] indices = {  // note that we start from 0!

         0, 1, 3,    // first triangle

         1, 2, 3,    // second triangle

         2, 5, 6    // misc triangle
        };
    float[] texCoords = {
    0.0f, 0.0f,  // lower-left corner  
    1.0f, 0.0f,  // lower-right corner
    0.5f, 1.0f   // top-center corner
};
    string colour = @"
     #version 330 core
     out vec4 FragColor;  
     in vec3 ourColor;

     // in vec2 texCoord;
     // uniform sampler2D texture0;

     void main()
     {
         FragColor = vec4(ourColor, 1.0);
     } ";
    string texCoord = @"   //fragment shader
    #version 330

     out vec4 outputColor;

     in vec2 texCoord;

     uniform sampler2D texture0;

     void main()
     {
       outputColor = texture(texture0, texCoord);
     }";
    string position = @"
     #version 330 core
     layout (location = 0) in vec2 aPos;   // the position variable has attribute position 0
     layout (location = 1) in vec3 aColor; // the color variable has attribute position 1
  
     out vec3 ourColor; // output a color to the fragment shader

     void main()
     {
        gl_Position = vec4(aPos.x, aPos.y, 0.0, 1.0);
        ourColor = aColor; // set ourColor to the input color we got from the vertex data      
     }";
    string texturePos = @"
     #version 330 core

     layout(location = 0) in vec3 aPosition;

     layout(location = 1) in vec2 aTexCoord;

     out vec2 texCoord;
     uniform mat4 transform;
     uniform mat4 model;
     uniform mat4 view;
     uniform mat4 projection;

     void main(void)
     {
        texCoord = aTexCoord;

        gl_Position = vec4(aPosition, 1.0);
    }";

    #region position_gsls(str-property)
    //tutorial: 
    /*
    
     //my kind frend from discord:
     string position = @"     
     #version 330

     in vec2 position;

     void main(void)
     {
         gl_Position = vec4(position, 0, 1);
     }";

    #endregion
    #region fragment_gsls(str-property)
    //tutorial:
    string colour = @"
     #version 330 core
     out vec4 FragColor;

     in vec4 vertexColor; // the input variable from the vertex shader (same name and same type)  

     void main()
     {
         FragColor = vertexColor;
     } ";
      //my kind frend from discord:
    string _colour = @"
    #version 330
    out vec4 color;

    void main(void)
    {
        color = vec4(0.5, 0.0, 0.5, 1.0);

    }
    ";
    */
    #endregion

    public Game(int width, int height, string title)
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            { ClientSize = (width, height), Title = title })
        {

        }
        protected override void OnUnload()
        {
            // unbind all the resources by binding the targets to 0/null.
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);

            // delete all the resources.
            GL.DeleteBuffer(vertexBufferObject);
            GL.DeleteVertexArray(vertexArrayObject_S);

            GL.DeleteProgram(handle);

            base.OnUnload();
        }

        protected override void OnLoad()
        {
            base.OnLoad();
                
            GL.ClearColor(0.8f, 0.3f, 0.1f, 1.0f);  //chooses colour background
        #region texVAO
        /*
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
        float[] borderColor = { 1.0f, 1.0f, 0.0f, 1.0f };
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureBorderColor, borderColor);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
          
        vertexArrayObject_T = GL.GenVertexArray(); //VAO's  
            GL.BindVertexArray(vertexArrayObject_T);       //VAO's


        int vertexLocation = GL.GetAttribLocation(texHandle, "aPosition");

        GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);   //very important VAO

        int texCoordLocation = GL.GetAttribLocation(texHandle, "aTexCoord");
        GL.EnableVertexAttribArray(texCoordLocation);
        GL.VertexAttribPointer(texCoordLocation, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));
        GL.EnableVertexAttribArray(0);

        GL.EnableVertexAttribArray(vertexArrayObject_T);

        texHandle = CreateProgram(texturePos, texCoord);
        */
        #endregion

        #region standardVAO
       
        vertexArrayObject_S = GL.GenVertexArray(); //VAO's  
        GL.BindVertexArray(vertexArrayObject_S);       //VAO's

        int vertexLocation_S = GL.GetAttribLocation(handle, "aPos");
        

        GL.VertexAttribPointer(vertexLocation_S, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);   //very important VAO             HARD CODED INSTEAD OF USING THE PREVIOUS VARIABLE IN THE FIRST PARAMETER
        GL.EnableVertexAttribArray(vertexLocation_S);

        int colorLocation_S = GL.GetAttribLocation(handle, "aColor");  //this is in vertex standard shader
        

        GL.VertexAttribPointer(colorLocation_S, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 2 * sizeof(float));   //very important VAO             HARD CODED INSTEAD OF USING THE PREVIOUS VARIABLE IN THE FIRST PARAMETER
        GL.EnableVertexAttribArray(colorLocation_S);

        

        handle = CreateProgram(position, colour);
        #endregion

        elementBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, elementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);

            vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);



        
        
        GL.UseProgram(handle);

        //Code goes here
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
         base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.UseProgram(handle);

        Vector4 vec = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
        Matrix4 trans = Matrix4.CreateTranslation(1f, 1f, 0.0f);
        vec *= trans;
        Console.WriteLine("{0}, {1}, {2}", vec.X, vec.Y, vec.Z);

        Matrix4 rotation = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(1f));
        
        Matrix4 scale = Matrix4.CreateScale(1f, 1f, 1f);
        trans = rotation * scale;

            GL.UseProgram(handle);

        int location = GL.GetUniformLocation(handle, "transform");

            GL.UniformMatrix4(location, true, ref trans);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);

        #region
        
        Matrix4 model = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-55.0f));
        //model = Matrix4.CreateRotationX((float)MathHelper.DegreesToRadians(time));

        Matrix4 view = Matrix4.CreateTranslation(0.0f, 0.0f, -3.0f);

        Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), width / height, 0.1f, 100.0f);


        int locationM = GL.GetUniformLocation(handle, "model");     //make location variable names better

          GL.UniformMatrix4(locationM, true, ref model);
          

        int locationV = GL.GetUniformLocation(handle, "view");

            GL.UniformMatrix4(locationV, true, ref view);
           
        int locationP = GL.GetUniformLocation(handle, "projection");

            GL.UniformMatrix4(locationP, true, ref projection);

        #endregion

            GL.BindVertexArray(vertexArrayObject_S);
        // time += 1;
        
        GL.DrawArrays(PrimitiveType.Triangles, 0, 36);
        //Console.WriteLine("balls");

        //GL.DrawElements(PrimitiveType.TriangleStrip, indices.Length, DrawElementsType.UnsignedInt, 0); //draw the several things

        SwapBuffers();
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            var input = KeyboardState;

            if (KeyboardState.IsAnyKeyDown)
            {
                Console.WriteLine("balls");
            }
           if (input.IsKeyDown(Keys.Escape))
           {
                 Close();
           }
    }


        int CreateShader(ShaderType type, string source)
        {
            int status;
            int shader = GL.CreateShader(type);
            GL.ShaderSource(shader, source);
            GL.CompileShader(shader);
            GL.GetShader(shader, ShaderParameter.CompileStatus, out status);
            if (status != 1)
            {
                Console.WriteLine(GL.GetShaderInfoLog(shader));
            }
            return shader;
        }
        int CreateProgram(string vertex, string fragment)
        {
            int status;
            int program = GL.CreateProgram();
            GL.AttachShader(program, CreateShader(ShaderType.VertexShader, vertex));
            GL.AttachShader(program, CreateShader(ShaderType.FragmentShader, fragment));
            GL.LinkProgram(program);
            GL.GetProgram(program, GetProgramParameterName.LinkStatus, out status);
            if (status != 1)
            {
                Console.WriteLine(GL.GetProgramInfoLog(program));
            }
        //GL.DetachShader(handle, VertexShader);
        //GL.DetachShader(handle, FragmentShader);
        //GL.DeleteShader(fragmentShade r);
        //GL.DeleteShader(vertexShader);

        return program;
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, e.Width, e.Height);
        }
    }

