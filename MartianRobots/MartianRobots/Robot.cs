using System;

namespace MartianRobots
{
    public class Robot
    {
        public int x; // x co-ord of current robot position
        public int y; // y co-ord of current robot position
        public string orientatation; // cardinal direction of current robot position
        public string lost = null;

        public int minXPoint = 0;
        public int minYPoint = 0;
        public int maxXPoint;
        public int maxYPoint;

        public int XPointLostScent;
        public int YPointLostScent;

        public Robot(string maxGridCoords, string location)
        {
            // Upper Right Co-ordinates for the grid
            int.TryParse(maxGridCoords.Split(' ')[0], out maxXPoint);
            int.TryParse(maxGridCoords.Split(' ')[1], out maxYPoint);

            // starting position of Robot
            int.TryParse(location.Split(' ')[0], out x);
            int.TryParse(location.Split(' ')[1], out y);
            orientatation = location.Split(' ')[2];
        }

        public void SpinLeft()
        {
            switch (orientatation)
            {
                case "N":
                    orientatation = "W";
                    break;
                case "E":
                    orientatation = "N";
                    break;
                case "S":
                    orientatation = "E";
                    break;
                case "W":
                    orientatation = "S";
                    break;
                default:
                    orientatation = null;
                    throw new ArgumentException();
            }
        }

        public void SpinRight()
        {
            switch (orientatation)
            {
                case "N":
                    orientatation = "E";
                    break;
                case "E":
                    orientatation = "S";
                    break;
                case "S":
                    orientatation = "W";
                    break;
                case "W":
                    orientatation = "N";
                    break;
                default:
                    orientatation = null;
                    throw new ArgumentException();
            }
        }

        public void StepForward()
        {
            switch (orientatation)
            {
                case "N":
                    y++;

                    // Ran out of time to work out the logic for the "off" world condition, can come back to it later, commented second part of condition
                    // Now check to see if the Robot has fallen of the grid
                    if (y > maxYPoint /*&& y != YPointLostScent && YPointLostScent != 0*/)
                    {
                        lost = "LOST";
                        YPointLostScent = y;

                    }

                    break;
                case "E":
                    x++;

                    // Now check to see if the Robot has fallen of the grid
                    if (x > maxXPoint)
                    {
                        lost = "LOST";
                    }

                    break;
                case "S":
                    y--;

                    // Now check to see if the Robot has fallen of the grid
                    if (y < minYPoint)
                    {
                        lost = "LOST";
                    }

                    break;
                case "W":
                    x--;

                    // Now check to see if the Robot has fallen of the grid
                    if (x < minXPoint)
                    {
                        lost = "LOST";
                    }

                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void FinalDestination(string command)
        {
            char[] commands = command.ToCharArray();
            
            //Loop through array, for each letter call SpinLeft, SpinRight or StepForward as appropriate.
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'F':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
