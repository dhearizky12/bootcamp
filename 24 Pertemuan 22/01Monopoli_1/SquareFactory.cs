using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoli_1
{
    abstract class SquareFactory
    {
        public abstract Square GetSquare(int position);
    }
}
