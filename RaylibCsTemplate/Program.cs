using Raylib_cs;
using static Raylib_cs.Raylib;

class Program
{
    public static void Main()
    {
        InitWindow(800, 600, "My raylib template");
        SetTargetFPS(60);
        while (!WindowShouldClose())
        {
            BeginDrawing();

            ClearBackground(Color.RayWhite);

            EndDrawing();
        }
        CloseWindow();
    }
}