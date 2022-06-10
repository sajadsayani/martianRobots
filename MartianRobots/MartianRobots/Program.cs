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
        private static Robot robot;
        private static int tempX = 0;
        private static int tempY;

        static void Main(string[] args)
        {
            int counter = 1;

            // read the Robot instruction file
            foreach (string line in System.IO.File.ReadLines(@"C:\RobotInstructions.txt"))
            {
                if (counter == 1)
                {
                    // set the upper right co-ordinates for the grid. This is line 1
                    int.TryParse(line.Split(' ')[0], out tempX);
                    int.TryParse(line.Split(' ')[1], out tempY);

                    Console.WriteLine(tempX);
                    Console.WriteLine(tempY);
                    //robot.maxXPoint = tempX; robot is not created here because it is null, that's why the error, so pass the max co-rds as parameter to Robot constructor and initialise in there
                    //robot.maxYPoint = tempY;
                }
                else
                {
                    // Using the % modulus operand to determine if the line is even or odd.
                    // I have made the assumtion that all even lines are the Robot starting position and the odd lines are the Robots movements. After the first line of course.
                    if (counter % 2 == 0)
                    {
                        // set the robot position
                        robot = new Robot(line);
                    }
                    else
                    {
                        // Now make the Robot move
                        robot.FinalDestination(line);

                        Console.WriteLine(robot.x + " " + robot.y + " " + robot.orientatation + " " + robot.lost);
                    }


                }

                counter++;
            }

            Console.WriteLine("\n \nPress any key to exit");
            Console.ReadKey();
        }
    }
}
