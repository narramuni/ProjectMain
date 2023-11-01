using System;
using System.Collections.Generic;
using System.IO;

namespace TeachersRecordClassLibrary
{
    public class SaveTeachersData
    {
        public static void SaveTeacherData(List<Teacher> teachers, string filePath)
        {
            List<string> teacherData = new List<string>();
            foreach (Teacher teacher in teachers)
            {
                teacherData.Add($"{teacher.ID}, {teacher.Name}, {teacher.ClassSection}");
            }

            File.WriteAllLines(filePath, teacherData);
        }
    }
}
