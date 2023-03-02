using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PZ_LinQ_Lamaev
{
    public class Group_log
    {
        public string Classroom_teacher { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public List<string> Students { get; set; } = new List<string>();
        
        public Group_log(string classroom_teacher, List<string> items, List<string> students)
        {
            this.Classroom_teacher = classroom_teacher;
            this.Items = items;
            this.Students = students;

        }



    }
}
