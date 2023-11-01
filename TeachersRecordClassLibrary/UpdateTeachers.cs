using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordClassLibrary
{
    public class UpdateTeachers
    {
        public static void UpdateTeacher(List<Teacher> teachers)
        {
            Console.Write("Enter the Teacher's ID to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Teacher teacherToUpdate = teachers.Find(t => t.ID == id);
                if (teacherToUpdate != null)
                {
                    Console.Write("Enter new Teacher Name: ");
                    teacherToUpdate.Name = Console.ReadLine();
                    Console.Write("Enter new Class and Section: ");
                    teacherToUpdate.ClassSection = Console.ReadLine();
                    Console.WriteLine("Teacher updated successfully.");
                }
                else
                {
                    Console.WriteLine("Teacher not found with the specified ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Teacher not updated.");
            }
        }


    }
}
