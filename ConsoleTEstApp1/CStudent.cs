using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTEstApp1
{
    internal class CStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public float  GPA { get; set; }

        public CStudent(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
;
        }
    }
}
