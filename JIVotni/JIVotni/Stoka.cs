using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIVotni
{
    internal class Stoka
    {
        private string ime;
        private string Jivotno;
        public string Ime { get; set; }
        public string vid { get; set; }

        public Stoka(string ime, string vid)
        {
            Ime = ime;
            this.vid = vid;
        }

       
    }
}
