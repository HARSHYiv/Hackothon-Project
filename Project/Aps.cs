using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Aps
    {
        private int APS_id;

        public int aps_id
        {
            get { return APS_id; }
            set { APS_id = value; }
        }

        private int ZeroTo29;

        public int zeroto29
        {
            get { return ZeroTo29; }
            set { ZeroTo29 = value; }
        }

        private int Thirties;

        public int thirties
        {
            get { return Thirties; }
            set { Thirties = value; }
        }

        private int Forties;

        public int forties
        {
            get { return Forties; }
            set { Forties = value; }
        }

        private int fifties;

        public int Fifties
        {
            get { return Fifties; }
            set { Fifties = value; }
        }

        private int sixties;

        public int Sixties
        {
            get { return sixties; }
            set { sixties = value; }
        }

        private int seventy;

        public int Seventy
        {
            get { return seventy; }
            set { seventy = value; }
        }
        private int eighty;

        public int Eighty
        {
            get { return eighty; }
            set { eighty = value; }
        }
        private int nintyTo100;

        public int NintyTo100
        {
            get { return nintyTo100; }
            set { nintyTo100 = value; }
        }


        public Aps(int ZeroTo29, int Thirties, int Forties, int Fifties, int Sixties, int Seventies, int Eighties, int NintyTo100)
        {
            this.zeroto29 = ZeroTo29;
            this.thirties = Thirties;
            this.forties = Forties;
            this.fifties = Fifties;
            this.sixties = Sixties;
            this.seventy = Seventies;
            this.eighty = Eighties;
            this.nintyTo100 = NintyTo100;

        }
    }
}
