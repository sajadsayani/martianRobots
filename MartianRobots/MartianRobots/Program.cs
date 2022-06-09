using System;

// Objects
//      Robot: Position and Location => (x, y, Z), where Z  in {N, E, S, W}
//      MarsSurface: Grid of Positions => (x, y, Z), where (0, 0, N) => (x=0, y=0, Z=N)
//                   MaxCoords => (maxX, MaxY)
//      Instruction: (cccccc) => c in (L, R, F) => (L=LeftSpin, R=RightSpin, F=Forward) 
//      Input Lines:
//          1. Surface Size
//          2. Array of RobotIntruction Object, where RobotInstruction object contains:
//              a. RobotPosition (first line)
//              b. RobotCommand (second line)

// Behaviours
//      1. Robot should spin Left
//      2. Robot should spin Right
//      3. Robot should move Forward

namespace MartianRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
