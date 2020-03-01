using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Course
    {
        private int course_id;

        public int Course_id
        {
            get { return course_id; }
            set { course_id = value; }
        }

        private int uni_id;

        public int Uni_id
        {
            get { return uni_id; }
            set { uni_id = value; }
        }

        private int facultyId;

        public int FacultyId
        {
            get { return facultyId; }
            set { facultyId = value; }
        }


        private string qualification;

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }

        private int aps;

        public int APS
        {
            get { return aps; }
            set { aps = value; }
        }

        public Course(int CorID, int Uni_id, int FacId, string Qual, int APs)
        {
            this.course_id = CorID;
            this.uni_id = Uni_id;
            this.facultyId = FacId;
            this.qualification = Qual;
            this.aps = APs;

        }



    }
}
