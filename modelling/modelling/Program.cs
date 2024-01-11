using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;


  //progress, on the vectors page, changed gsls code, not sure where to put the transformations code at start of "in practice)
using (Game game = new Game(800, 600, "hello"))
{

    game.Run();

}

    public class Game : GameWindow
    {

        int vertexArrayObject;

        int vertexBufferObject;

        int elementBufferObject;

        int handle;  //shader thingy, can put in a shader class for organisation later if i want

       // int vertexBufferArray;

        float[] vertices = {
         0.5f,  0.5f, 0.0f,  // top right
         0.5f, -0.5f, 0.0f,  // bottom right
        -0.5f, -0.5f, 0.0f,  // bottom left
        -0.5f,  0.5f, 0.0f   // top left
        };
        uint[] indices = {  // note that we start from 0!

         0, 1, 3,    // first triangle

         1, 2, 3,    // second triangle

        // 2, 5, 6    // misc triangle
        };

        #region position_gsls(str-property)
        //tutorial: 
        string position = @"
         #version 330 core
         layout (location = 0) in vec3 aPos;
         layout (location = 1) in vec2 aTexCoord;

         out vec2 TexCoord;
  
         uniform mat4 transform;

         void main()
        {
           gl_Position = vec4(aPos, 1.0f) * transform;
           TexCoord = vec2(aTexCoord.x, aTexCoord.y);
        }";
        /* //my kind frend from discord:
         string _position = @"     
         #version 330
        
         in vec2 position;

         void main(void)
         {
             gl_Position = vec4(position, 0, 1);
         }";
        */
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
        /*  //my kind frend from discord:
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
            GL.DeleteVertexArray(vertexArrayObject);

            GL.DeleteProgram(handle);

            base.OnUnload();
        }

        protected override void OnLoad()
        {
            base.OnLoad();
                
            GL.ClearColor(0.8f, 0.3f, 0.1f, 1.0f);  //chooses colour background

            vertexArrayObject = GL.GenVertexArray(); //VAO's  
            vertexBufferObject = GL.GenBuffer();      
            elementBufferObject = GL.GenBuffer();

            GL.BindVertexArray(vertexArrayObject);       //VAO's

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, elementBufferObject);

            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBufferObject);

            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);   /*very important VAO
                                                                                                        * IM OVER HERE, LEARN AND EXPLAIN OVER HERE WHAT THE PARAMETERS MEAN, need understand VAOsS
                                                                                                        */
            GL.EnableVertexAttribArray(0);
            
            GL.UseProgram(handle);

            vertexBufferObject = GL.GenBuffer();
            GL.EnableVertexAttribArray(vertexArrayObject);


            //GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);         // these 2 lines may need to be removed or put somewhere else

            handle = CreateProgram(position, colour);


            //Code goes here
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.UseProgram(handle);

            GL.BindVertexArray(vertexArrayObject);

        //Vector4 vec = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);
        //Matrix4 trans = Matrix4.CreateTranslation(1f, 1f, 0.0f);
        //vec *= trans;
        //Console.WriteLine("{0}, {1}, {2}", vec.X, vec.Y, vec.Z);    // funny

        //GL.DrawArrays(PrimitiveType.Triangles, 0, 3);   //dont put this back in, it is an alternative tho
        Matrix4 rotation = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(90.0f));
        Matrix4 scale = Matrix4.CreateScale(0.5f, 0.5f, 0.5f);
        Matrix4 trans = rotation * scale;
        GL.DrawElements(PrimitiveType.TriangleStrip, indices.Length, DrawElementsType.UnsignedInt, 0); //draw the several things

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
            return program;
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, e.Width, e.Height);
        }
    }

