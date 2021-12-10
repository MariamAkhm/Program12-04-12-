using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace met13
{
    class Building
    {
        private static int id = 1;
        private int number;
        private int height;
        private int countOfFloors;
        private int countOfApartments;
        private int countOfEntrances;
        public int Number => number;
        public int Height => height;
        public int CountOfFloors => countOfFloors;
        public int CountOfApartments => countOfApartments;
        public int CountOfEntrances => countOfEntrances;
        public Building(int height, int countOfFloors, int countOfApartments, int countOfEntrances)
        {
            number = ID();
            this.height = height;
            this.countOfFloors = countOfFloors;
            this.countOfApartments = countOfApartments;
            this.countOfEntrances = countOfEntrances;
        }
        public static int ID()
        {
            return id++;
        }
        public double HeightFloor(double height, double countOfFloors)
        {
            double heightOfFloors;
            if (countOfFloors != 0)
            {
                heightOfFloors = height / countOfFloors;
                Console.WriteLine(heightOfFloors);
            }
            else
            {
                heightOfFloors = height;
                Console.WriteLine(heightOfFloors);
            }
            return heightOfFloors;
        }
        public int CountApartmentsInEntrance(int countOfApartments, int countOfEntrances)
        {
            int apartOfEntrances;
            if (countOfEntrances != 0)
            {
                apartOfEntrances = countOfApartments / countOfEntrances;
                Console.WriteLine(apartOfEntrances);
            }
            else
            {
                apartOfEntrances = countOfApartments;
                Console.WriteLine(apartOfEntrances);
            }
            return apartOfEntrances;
        }
        public int CountApartmentsOnFloor(int countOfApartments, int countOfFloors)
        {
            int apartOfFloors;
            if (countOfFloors != 0)
            {
                apartOfFloors = countOfApartments / countOfFloors;
                Console.WriteLine(apartOfFloors);
            }
            else
            {
                apartOfFloors = countOfApartments;
                Console.WriteLine(apartOfFloors);
            }
            return apartOfFloors;
        }
    }
}
