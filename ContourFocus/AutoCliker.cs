using WindowsInput;
using System.Runtime.InteropServices;

namespace ContourFocus
{
    public static class AutoCliker
    {
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string InputText { get; set; }
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        public static Point ShowMousePosition()
        {
            Point point;
            if (GetCursorPos(out point))
            {
                Console.Clear();
                Console.WriteLine("({0},{1})", point.X, point.Y);
            }

            return point;
        }

        public static void Click(Point point)
        {
            double x = Convert.ToDouble(point.X * 65535 / 1920);
            double y = Convert.ToDouble(point.Y * 65535 / 1080);
            var simulator = new InputSimulator();

            simulator.Mouse.MoveMouseTo(x, y);
            simulator.Mouse.LeftButtonClick();

            System.Threading.Thread.Sleep(1000);
        }

        public static void InputText(Point point)
        {
            double x = Convert.ToDouble(point.X * 65535 / 1920);
            double y = Convert.ToDouble(point.Y * 65535 / 1080);
            var simulator = new InputSimulator();

            simulator.Mouse.MoveMouseTo(x, y);
            simulator.Mouse.LeftButtonClick();
            simulator.Keyboard.TextEntry(point.InputText);

            System.Threading.Thread.Sleep(1000);
        }

        public static List<Point> AddPoints()
        {
            var points = new List<Point>();

            // Select file
            points.Add(new Point { X = 2683, Y = 574, InputText = @"C:\Users\user\source\repos\ContourFocus\ContourFocus\Result\input.csv"});
            points.Add(new Point { X = 3002, Y = 596 });

            return points;
        }
    }
}
