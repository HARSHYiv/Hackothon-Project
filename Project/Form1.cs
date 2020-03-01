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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void CheckComboBox() 
        {
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

            for (int i = 0; i < subjects.Count; i++)
            {
                if (cbxOne.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;

                }
                else if (cbxTwo.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;
                }
                else if (cbxThree.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;
                }
                else if (cbxFour.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;
                }
                else if (cbxFive.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;
                }
                else if (cbxSix.SelectedItem.ToString() == subjects[i].ToString())
                {
                    subjects.RemoveAt(i);
                    Refresher();
                    break;
                }

               
            }
            

        }

        public void Refresher() 
        {
            cbxOne.Items.Clear();
            cbxTwo.Items.Clear();
            cbxThree.Items.Clear();
            cbxFour.Items.Clear();
            cbxFive.Items.Clear();
            cbxSix.Items.Clear();

            for (int j = 0; j < subjects.Count; j++)
            {

                cbxOne.Items.Add(subjects[j]);
                cbxTwo.Items.Add(subjects[j]);
                cbxThree.Items.Add(subjects[j]);
                cbxFour.Items.Add(subjects[j]);
                cbxFive.Items.Add(subjects[j]);
                cbxSix.Items.Add(subjects[j]);
            }
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
    }
}
