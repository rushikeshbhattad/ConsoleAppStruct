﻿using System;

namespace StructDemo
{
    class Program
    {
        struct Student
        {
            internal string Name, Course;
            internal int Sam, Rishu;

        }
        static void Main(string[] args)
        {
            Student S1;
            Console.Write("Enter Student Name: ");
            S1.Name = Console.ReadLine();
            Console.Write("Enter Student Course: ");
            S1.Course = Console.ReadLine();
            Console.Write("Enter Student ID: ");
            S1.Sam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Registration Number: ");
            S1.Rishu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Name\tCourse\tID\tReg No.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", S1.Name, S1.Course, S1.Sam, S1.Rishu);
            Console.ReadKey(); 
        }
    }
}