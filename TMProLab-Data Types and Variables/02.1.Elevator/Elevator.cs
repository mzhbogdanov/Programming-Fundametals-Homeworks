using System;

    class Elevator
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int coursesOfElevator = (int) Math.Ceiling((double)numberOfPeople/capacityOfElevator);

            Console.WriteLine(coursesOfElevator);
        }
    }

