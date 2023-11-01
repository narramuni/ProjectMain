using System;
using System.Collections.Generic;
using System.IO;
using TeachersRecordClassLibrary;

namespace ProjectMain
{
    public class Program
    {
         static List<Teacher> teachers = new List<Teacher>();

        static void Main(string[] args)
        {
            LoadTeachersData.LoadTeacherData(teachers, @"C:\Users\SAI PAVAN KUMAR\source\repos\ProjectMain\teachers.txt");

            while (true)
            {
                Console.WriteLine("\nTeacher Data System");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Display Teachers");
                Console.WriteLine("3. Update Teacher");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddTeachers.AddTeacher(teachers);
                            break;
                        case 2:
                            DisplayTeachers.DisplayTeacher(teachers);
                            break;
                        case 3:
                            UpdateTeachers.UpdateTeacher(teachers);
                            break;
                        case 4:
                            SaveTeachersData.SaveTeacherData(teachers, @"C:\Users\SAI PAVAN KUMAR\source\repos\ProjectMain\teachers.txt");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }
    }
}
