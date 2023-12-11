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

    public class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(GameWindowSettings.Default, new NativeWindowSettings(){ ClientSize = (width, height), Title = title }) 
        {
        }
    }
}
