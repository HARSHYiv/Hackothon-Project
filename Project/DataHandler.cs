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
<<<<<<< HEAD
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5620AL5O\\SQLEXPRESS;Initial Catalog=404Error_Project_DB;Integrated Security=True");
=======
        SqlConnection conn = new SqlConnection("data");
>>>>>>> master

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
<<<<<<< HEAD
                    uniList.Add(new University(Convert.ToInt16(rdrReader[0]),Convert.ToInt16(rdrReader[1]),Convert.ToInt16(rdrReader[2])));
=======
                    uniList.Add(new University());
>>>>>>> master
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
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
<<<<<<< HEAD
                    apsList.Add(new Aps(Convert.ToInt16(rdrReader[0]), Convert.ToInt16(rdrReader[1]), Convert.ToInt16(rdrReader[2]), Convert.ToInt16(rdrReader[3]), Convert.ToInt16(rdrReader[4]), Convert.ToInt16(rdrReader[5]), Convert.ToInt16(rdrReader[6]), Convert.ToInt16(rdrReader[7])));
=======
                    apsList.Add(new Aps());
>>>>>>> master
                }
            }
            catch (Exception ea)
            {

                throw new Exception(ea.Message);
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
<<<<<<< HEAD
            return apsList;
=======
            return uniList;
>>>>>>> master
        }
    }
}
