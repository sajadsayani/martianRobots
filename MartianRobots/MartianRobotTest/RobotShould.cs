using MartianRobots;

namespace MartianRobotTest
{
    public class RobotShould
    {
        [Fact]
        public void SpinLeft()
        {
            //arrange
            Robot robot = new Robot("5 3", "1 1 E");

            //act
            robot.SpinLeft();

            //assert
            Assert.Equal("N", robot.orientatation);
        }

        [Fact]
        public void SpinRight()
        {
            //arrange
            Robot robot = new Robot("5 3", "1 1 E");

            //act
            robot.SpinRight();

            //assert
            Assert.Equal("S", robot.orientatation);
        }

        [Fact]
        public void StepForward()
        {
            //arrange
            Robot robot = new Robot("5 3", "1 1 E");

            //act
            robot.StepForward();

            //assert
            Assert.Equal(2, robot.x);
        }

        [Fact]
        public void FinalPosition()
        {
            //arrange
            Robot robot = new Robot("5 3", "1 1 E");

            //act
            robot.FinalDestination("RFRFRFRF");

            //assert
            Assert.Equal("1 1 E", robot.x + " " + robot.y + " " + robot.orientatation);
        }
    }
}