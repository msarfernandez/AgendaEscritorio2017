using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda2017_1
{
    public class Localidad
    {
        public Int32 Id { set; get; }
        public Int32 CP { set; get; }
        public String Localid { set; get; }

        public override string ToString()
        {
            return CP.ToString() + " - " + Localid;
        }

    }
}
