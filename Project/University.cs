﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class University
    {
        private int uni_id;

        public int Uni_Id
        {
            get { return uni_id; }
            set { uni_id = value; }
        }

        private int aps_id;

        public int APS_ID
        {
            get { return aps_id; }
            set { aps_id = value; }
        }

        private int uniName;

        public int UniName
        {
            get { return uniName; }
            set { uniName = value; }
        }

        public University(int id, int Aps_id, int Names)
        {
            this.uni_id = id;
            this.aps_id = Aps_id;
            this.uniName = Names;
        }

    }
}
