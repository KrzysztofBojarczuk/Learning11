using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32
{
    public class Truck : Automobile
    {
        private string _drive;
        public Truck()
        {
            _drive = "";
        }
        public string Drive
        {
            get { return _drive; }
            set { _drive = value; }
        }

    }
   
}
