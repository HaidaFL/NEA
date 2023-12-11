using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;



using (_a.Game game = new _a.Game(800, 600, "LearnOpenTK"))
{
    
    game.Run();

}
namespace _a
{
    //add co-ordinates

    public class Game : GameWindow
    {
        public Game(int width, int height, string title) 
            : base(GameWindowSettings.Default, new NativeWindowSettings()
            { ClientSize = (width, height), Title = title }) 
        {

        }
        protected override void OnLoad()
        {
            base.OnLoad();

            GL.ClearColor(0.5f, 0.3f, 0.3f, 1.0f);

            //Code goes here
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
