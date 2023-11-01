using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordClassLibrary
{
    public class AddTeachers
    {
        public static void AddTeacher(List<Teacher> teachers)
        {
            Console.Write("Enter Teacher ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Enter Teacher Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Class and Section: ");
                string classSection = Console.ReadLine();

                teachers.Add(new Teacher { ID = id, Name = name, ClassSection = classSection });
                Console.WriteLine("Teacher added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid input. Teacher not added.");
            }
        }

    }
}
