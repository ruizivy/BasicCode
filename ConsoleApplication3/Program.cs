using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Rectangle
    {
        double width;
        double length;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: "+ width);
            Console.WriteLine("Area: "+ GetArea());

        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
                Console.ReadLine();

                int count = 0;
                while (count < 5)
                {
                   
                    Console.WriteLine("Count : " + count);
                    count++;
                }

           
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Loop :" + i);
                }

                char grade = Convert.ToChar(Console.ReadLine());
                grade = 'A';

                switch (grade)
                {
                    case 'A' : 
                        Console.WriteLine("Very Good !!");
                        break;
                    case 'B' :
                        Console.WriteLine("Pretty Good !!");
                    default: Console.WriteLine("Ewan ko XD");
                }
        }
    }
}
