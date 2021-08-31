using System;

namespace grade2ex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double rl, phy, che, ca, m1, m2;
           
            string nm;
            string[] studentId = { "STU01", "STU02", "STU03", "STU04", "STU05" };
            int[] marks = { 76, 83, 92, 65, 34 };

            Console.Write("\n\n");
            Console.Write("Calculate the grade,   to take marks of five subjects:\n");
           
            Console.Write("\n\n");

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of m1 : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  m2 : ");
            che = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finds the grade for each student");
            for (int i = 0; i < studentId.Length; i++)
            {
                if (marks[i] > 90)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "A");
                }
                else if (marks[i] > 80)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "B");
                }
                else if (marks[i] > 70)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "C");
                }
                else if (marks[i] > 50)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "D");
                }
                else
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "FAIL");
                }
            }
            Console.ReadKey();

            
            }
        }
    }

   