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
    public partial class Display : Form
    {
        int ApsTotal = 0;
        public Display(int Total)
        {
            InitializeComponent();
            ApsTotal = Total;
        }

        DataHandler dh;
        List<Course> crsList = new List<Course>();

        public void ShowOutput()
        {
            List<Course> cnl = new List<Course>();

            for (int i = 0; i < crsList.Count; i++)
            {
                if (ApsTotal >= crsList[i].APS)
                {
                    cnl.Add(crsList[i]);
                }
            }

            List<string> results = dh.SortC(cnl);

            foreach (var item in results)
            {
                lbxResults.Items.Add(item);
            }
        }
    }
}
