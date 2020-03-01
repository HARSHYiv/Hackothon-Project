using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    public class DataHandler
    {
        //public static string data = "hgvyuybub";
 
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5620AL5O\\SQLEXPRESS;Initial Catalog=404Error_Project_DB;Integrated Security=True");


        SqlDataReader rdrReader = null;
        //Reading the university data from the database
        public List<University> ReadUniversity()
        {
            List<University> uniList = new List<University>();
            try
            {
                conn.Open();
                SqlCommand cmdReadUni = new SqlCommand("Select  * From tblUniversity", conn);
                while (rdrReader.Read())
                {
                    uniList.Add(new University(Convert.ToInt16(rdrReader[0]),Convert.ToInt16(rdrReader[1]),rdrReader[2].ToString() ));
                    
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if (rdrReader != null)
                {
                    rdrReader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return uniList;
        }

        //Reading the APS data from the database
        public List<Aps> ReadAPS()
        {
            List<Aps> apsList = new List<Aps>();
            try
            {
                conn.Open();
                SqlCommand cmdReadAPS = new SqlCommand("Select  * From tblAPS Key", conn);
                while (rdrReader.Read())
                {

                    apsList.Add(new Aps(Convert.ToInt16(rdrReader[0]), Convert.ToInt16(rdrReader[1]), Convert.ToInt16(rdrReader[2]), Convert.ToInt16(rdrReader[3]), Convert.ToInt16(rdrReader[4]), Convert.ToInt16(rdrReader[5]), Convert.ToInt16(rdrReader[6]), Convert.ToInt16(rdrReader[7])));
            

                }
            }
            catch (Exception ea)
            {

                Console.WriteLine(ea.Message);
            }
            finally
            {
                if (rdrReader != null)
                {
                    rdrReader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return apsList;

       }

        public List<Course> ReadCourses()
        {
            List<Course> courseList = new List<Course>();
            try
            {
                conn.Open();
                SqlCommand cmdReadUni = new SqlCommand("Select  * From tblUniversity", conn);
                while (rdrReader.Read())
                {
                    courseList.Add(new Course(Convert.ToInt16(rdrReader[0]), Convert.ToInt16(rdrReader[1]), Convert.ToInt16(rdrReader[2]), rdrReader[3].ToString(), Convert.ToInt16(rdrReader[4])));

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                if (rdrReader != null)
                {
                    rdrReader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return courseList;
        }

        public List<string> SortC(List<Course> courses)
        {
            DataHandler dh = new DataHandler();
            List<University> universities = dh.ReadUniversity();
            List<string> uni = new List<string>();

            for (int i = 0; i < courses.Count ; i++)
            {
                uni.Add(courses[i].Qualification);

                for (int j = 0; j < universities.Count; j++)
                {
                    if (universities[j].Uni_Id == courses[i].Uni_id)
                    {

                        uni.Add(universities[j].UniName);

                    }
                }
                

            }

            return uni; 
        }

    }
}
