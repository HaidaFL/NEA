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
        int VertexBufferObject;

        int VertexBufferArray;

        float[] _vertices = {

      -0.5f, -0.5f, 0.0f, //Bottom-left vertex

       0.5f, -0.5f, 0.0f, //Bottom-right vertex

       0.0f,  0.5f, 0.0f  //Top vertex

       };

        #region  // this passes glsl code into gpu
        string _position = @"     
        #version 330
        
        in vec2 position;

        void main(void)
        {
            gl_Position = vec4(position, 0, 1);
        }
        ";
        #endregion

        #region
        string _colour = @"
        #version 330
        out vec4 color;

        void main(void)
        {
            color = vec4(0.5, 0.0, 0.5, 1.0);
           
        }
        ";
        #endregion
        string vec4 = @"uniform vec4 drawColor;";

        public Game(int width, int height, string title)
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            { ClientSize = (width, height), Title = title })
        {

        }
        protected override void OnLoad()
        {
            base.OnLoad();

            GL.ClearColor(0.5f, 0.3f, 0.3f, 1.0f);  //chooses colour background

            VertexBufferObject = GL.GenBuffer();

            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);

            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);

            //GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);         // these 2 lines may need to be removed or put somewhere else
  
            CreateProgram(_position, _colour); //change this a lil bit
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
       

       
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            if (KeyboardState.IsAnyKeyDown)
            {
                Console.WriteLine("balls");
            }
        }
    }
}
