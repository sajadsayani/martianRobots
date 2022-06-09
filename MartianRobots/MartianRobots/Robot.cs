using System;

namespace MartianRobots
{
    public class Robot
    {
        public int x; // x co-ord of current robot position
        public int y; // y co-ord of current robot position
        public string orientatation; // cardinal direction of current robot position

        public Robot(string location)
        {
            Int32.TryParse(location.Split(' ')[0], out x);
            Int32.TryParse(location.Split(' ')[1], out y);
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
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    y--;
                    break;
                case "W":
                    x--;
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
