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
        SqlConnection conn = new SqlConnection("data");

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
                    uniList.Add(new University());
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
                    apsList.Add(new Aps());
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
            return uniList;
        }
    }
}
