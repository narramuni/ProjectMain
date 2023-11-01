using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersRecordClassLibrary
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassSection { get; set; }

        public override string ToString()
        {
            return($"ID: {ID}, Name: {Name}, Class: {ClassSection}");
        }
    }
}
