using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp32
{
    public class SportUtility : Automobile
    {
        private int _passengers;

        public SportUtility()
        {
            _passengers = 0;
        }
        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }
    }
}
