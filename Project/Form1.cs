using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        List<string> subjects;
        BindingSource bs = new BindingSource();
        DataHandler dh = new DataHandler();

        List<Aps> apsList = new List<Aps>();
        List<University> uniList = new List<University>();
        List<Course> crsList = new List<Course>();

        public Form1()
        {
            InitializeComponent();
            subjects = new List<string>();

            

            subjects.Add("Math");
            subjects.Add("Home Language");
            subjects.Add("1st Additional Language");
            subjects.Add("Physical Science");
            subjects.Add("Life Science");
            subjects.Add("Egineering Graphics and Design");
            subjects.Add("Information Technology");
            subjects.Add("Geography");
            subjects.Add("History");
            subjects.Add("Accounting");

            bs.DataSource = subjects;
            //CheckComboBox();
            for (int i = 0; i < subjects.Count; i++)
            {
                cbxOne.Items.Add(subjects[i]);
                cbxTwo.Items.Add(subjects[i]);
                cbxThree.Items.Add(subjects[i]);
                cbxFour.Items.Add(subjects[i]);
                cbxFive.Items.Add(subjects[i]);
                cbxSix.Items.Add(subjects[i]);
            }

        }
        public void Apply()
        {
            
                if (subjects.Contains(cbxOne.Text))
                {

                    cbxOne.SelectedItem = subjects;
                    subjects.Remove(cbxOne.Text);
                    Refresher();
                    
                }

                if (subjects.Contains(cbxTwo.Text))
                {
                    subjects.Remove(cbxTwo.Text);
                    Refresher();
                   
                }
                else
                if (subjects.Contains(cbxThree.Text))
                {
                    subjects.Remove(cbxThree.Text);
                    Refresher();
                  
                }
                else
                if (subjects.Contains(cbxFour.Text))
                {
                    subjects.Remove(cbxFour.Text);
                    Refresher();
                   
                }
                else
                if (subjects.Contains(cbxFive.Text))
                {
                    subjects.Remove(cbxFive.Text);
                    Refresher();
                   
                }
                else if (subjects.Contains(cbxSix.Text))
                {
                    subjects.Remove(cbxSix.Text);
                    Refresher();
                    
                }
            if (chkDone.Checked)
            {
                cbxOne.Enabled = false;
                cbxTwo.Enabled = false;
                cbxThree.Enabled = false;
                cbxFour.Enabled = false;
                cbxFive.Enabled = false;
                cbxSix.Enabled = false;

            }

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Apply();
           
        }

        public void CheckComboBox()
        {


            //while(true)
            //{
            //    if (cbxOne.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;

            //    }
            //    else if (cbxTwo.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;
            //    }
            //    else if (cbxThree.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;
            //    }
            //    else if (cbxFour.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;
            //    }
            //    else if (cbxFive.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;
            //    }
            //    else if (cbxSix.SelectedItem.ToString() == subjects[i].ToString())
            //    {
            //        subjects.RemoveAt(i);
            //        Refresher();
            //        break;
            //    }


            //}

          

        }

        public void Refresher()
        {
            bs.DataSource = null;
            bs.DataSource = subjects;

            cbxOne.DataSource = bs;
            cbxTwo.DataSource = bs;
            cbxThree.DataSource = bs;
            cbxFour.DataSource = bs;
            cbxFive.DataSource = bs;
            cbxSix.DataSource = bs;

        }



        private void cbxOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void cbxTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void cbxThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void cbxFour_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void cbxFive_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        private void cbxSix_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox();
        }

        public void getAPS()
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<int> marks = new List<int>();
            marks.Add(int.Parse(txtOne.Text));
            marks.Add(int.Parse(txtTwo.Text));
            marks.Add(int.Parse(txtThree.Text));
            marks.Add(int.Parse(txtFour.Text));
            marks.Add(int.Parse(txtFive.Text));
            marks.Add(int.Parse(txtSix.Text));

            apsList = dh.ReadAPS();
            uniList = dh.ReadUniversity();


            int total = 0;
            for (int i = 0; i < uniList.Count; i++)
            {
                int ASPT = uniList[i].APS_ID;

                Aps temp = apsList[ASPT];

                int ApsCount = 0;

                for (int j = 0; j < marks.Count; j++)
                {

                    if (marks[j] > 90 || marks[j] < 100)
                    {
                        ApsCount = ApsCount + temp.NintyTo100;
                    }
                    else if (marks[j] > 80 || marks[j] < 89)
                    {
                        ApsCount = ApsCount + temp.Eighty;
                    }
                    else if (marks[j] > 70 || marks[j] < 79)
                    {
                        ApsCount = ApsCount + temp.Seventy;
                    }
                    else if (marks[j] > 60 || marks[j] < 69)
                    {
                        ApsCount = ApsCount + temp.Sixties;
                    }
                    else if (marks[j] > 50 || marks[j] < 59)
                    {
                        ApsCount = ApsCount + temp.Fifties;
                    }
                    else if (marks[j] > 40 || marks[j] < 49)
                    {
                        ApsCount = ApsCount + temp.forties ;
                    }
                    else if (marks[j] > 30 || marks[j] < 39)
                    {
                        ApsCount = ApsCount + temp.thirties;
                    }
                    else if (marks[j] > 0 || marks[j] < 29)
                    {
                        ApsCount = ApsCount + temp.zeroto29;
                    }
                }
                total = ApsCount;
            }

            Display ds = new Display(total);
            ds.Show();
            this.Hide();
        }
    }
}
