using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordClassLibrary
{
    public class DisplayTeachers
    {
        public static void DisplayTeacher(List<Teacher> teachers)
        {
            Console.WriteLine("List of Teachers:");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}
