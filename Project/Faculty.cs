using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Faculty
    {
        private int faculty_id;

        public int Paculty_id
        {
            get { return faculty_id; }
            set { faculty_id = value; }
        }

        private string facultyname;

        public string FacultyName
        {
            get { return facultyname; }
            set { facultyname = value; }
        }


        public Faculty(int id, string name)
        {
            this.faculty_id = id;
            this.facultyname = name;
        }
    }
}
