using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    class CoreSizeComparer
    {
        public int Compare(Core x, Core y)
        {
            if (x.Size < y.Size)
                return -2;
            else if (x.Size > y.Size)
                return 2;
            else
                return 0;
        }

    }
}
