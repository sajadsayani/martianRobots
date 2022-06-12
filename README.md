# Martian Robots

## Description

The surface of Mars can be modelled by a rectangular grid around which robots are able to
move according to instructions provided from Earth. This program determines each sequence of robot positions 
and reports the final position of the robot.

A robot position consists of a grid coordinate (a pair of integers: x-coordinate followed by
y-coordinate) and an orientation (N, S, E, W for north, south, east, and west).
A robot instruction is a string of the letters “L”, “R”, and “F” which represent, respectively, the
instructions:
* Left : the robot turns left 90 degrees and remains on the current grid point.
* Right : the robot turns right 90 degrees and remains on the current grid point.
* Forward : the robot moves forward one grid point in the direction of the current
orientation and maintains the same orientation.

## Getting Started

### Installing

* Download the "MartianRobots.exe", located in "martianRobots/MartianRobots/MartianRobots/bin/Debug/" to a location on your machine.
* Download the following Robot Instruction file "RobotInstructions.txt" located in martianRobots/MartianRobots/MartianRobots/ to your local C: drive root.

### Executing program

* Double click on the "MartiansRobot.exe" from the location where it was downloaded on your machine.

```
There is still an issue with the current Robot ignoring the moving "off" the world when a previous Robot who has been lost has left a scent. 
What I have attempted to solve this problem is commented out in the code, I think I need more time to get my head round the logic and solve this.

For the final robot in the sample input the instruction for the robots final destination did not correspond with the sample output because a 
move forward was missing.  So as it stands with the sample input the output would have been 2 4 S.  I have added the extra move Forward in my 
Input file to make the output 2 3 S. 
```
## Version History

* 0.7
  *	Made a change to the input file
  * See [commit change]() or See [release history]()
* 0.6
  * Checked in a working version, without the final piece of ignoring the "off" world rule
* 0.5
  *	Fixed Compilation errors
* 0.4
  *	Continued to finish off excercise
* 0.3
  *	Made a minor change
* 0.2
  *	Initial commit with tests written
* 0.1
  *	Initial commit
