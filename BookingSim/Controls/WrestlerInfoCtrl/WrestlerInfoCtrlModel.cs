using DataDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSim.Controls
{
    class WrestlerInfoCtrlModel
    {
        private WrestlerType _wrestler;

        public WrestlerType Wrestler
        {
            get { return Wrestler; }
            set
            {
                _wrestler = value;
            }
        }
    }
}
