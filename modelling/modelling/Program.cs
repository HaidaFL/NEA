using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;



using (_a.Game game = new _a.Game(800, 600, "hello"))
{

    game.Run();

}
namespace _a
{
    //add co-ordinates

    public class Game : GameWindow
    {
        int Handle;  //shader thingy, can put in a shader class for organisation later if i want

        int VertexBufferObject;

        int VertexBufferArray;

        float[] _vertices = {

      -0.5f, -0.5f, 0.0f, //Bottom-left vertex

       0.5f, -0.5f, 0.0f, //Bottom-right vertex

       0.0f,  0.5f, 0.0f  //Top vertex

       };

        #region  // this passes glsl code into gpu
        //tutorial:
        string _position = @"
         #version 330 core
         layout (location = 0) in vec3 aPos; // the position variable has attribute position 0
  
         out vec4 vertexColor; // specify a color output to the fragment shader

         void main()
         {
             gl_Position = vec4(aPos, 1.0); // see how we directly give a vec3 to vec4's constructor
             vertexColor = vec4(0.5, 0.0, 0.0, 1.0); // set the output variable to a dark-red color
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

        #region
        //tutorial:
        string _colour = @"
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
        string vec4 = @"uniform vec4 drawColor;";

        public Game(int width, int height, string title)
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            { ClientSize = (width, height), Title = title })
        {

        }
        protected override void OnUnload()
        {
            GL.DeleteProgram(Handle);
        }

        protected override void OnLoad()
        {
            base.OnLoad();

            int VertexArrayObject = GL.GenVertexArray(); //VAO's  
            GL.BindVertexArray(VertexArrayObject);       //VAO's

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);   /*very important VAO
                                                                                                        * IM OVER HERE, LEARN AND EXPLAIN OVER HERE WHAT THE PARAMETERS MEAN, need understand VAOs
                                                                                                        * 
                                                                                                        * 
                                                                                                        */
            GL.EnableVertexAttribArray(0);




            GL.ClearColor(0.5f, 0.3f, 0.3f, 1.0f);  //chooses colour background

            VertexBufferObject = GL.GenBuffer();

            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);

            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);

            //GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);         // these 2 lines may need to be removed or put somewhere else
  
            Handle = CreateProgram(_position, _colour);

            //Code goes here
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

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            // GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, 0);
            if (KeyboardState.IsAnyKeyDown)
            {
                Console.WriteLine("balls");
            }
            SwapBuffers();
        }
    }
}
