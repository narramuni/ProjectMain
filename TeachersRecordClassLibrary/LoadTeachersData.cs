using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordClassLibrary
{
    public class LoadTeachersData
    {
        public static void LoadTeacherData(List<Teacher> teachers,string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1].Trim();
                        string classSection = parts[2].Trim();
                        teachers.Add(new Teacher { ID = id, Name = name, ClassSection = classSection });
                    }
                }
            }
            else
            {
                Console.WriteLine("Teacher data file not found. Creating a new file.");
            }
        }

    }
}
