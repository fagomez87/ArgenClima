using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArgenClima.Models
{
    public class Preferences
    {
        public List<string> ciudad;

        public List<string> Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public override string ToString()
        {
            return "Ciudad: " + ciudad;
        }
    }
}