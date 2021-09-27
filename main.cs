using System;

class Program {
  public static void Main (string[] args) {
   
double distance;
double time;
double speed;
double average;
double total = 0;
int counter=0;
int numofcars;

Console.WriteLine("Enter the number of cars: ");
numofcars = Convert.ToInt32(Console.ReadLine());

while(counter<numofcars)
{
counter++;
Console.WriteLine("Enter the distance covered by car #" +counter+ ": ");
distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the time taken by car #" +counter+ ": ");
time = Convert.ToDouble(Console.ReadLine());
speed = distance/time;
total= total + speed;
Console.WriteLine("The speed of this car is: "+speed+ " miles per hour.");
}
average = total/numofcars;

Console.WriteLine("The average speed of the cars is "+average+" miles per hour.");





  }
}