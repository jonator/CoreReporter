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
    class CoreNameComparer
    {
        public int Compare(Core x, Core y)
        {
            return string.Compare(x.CoreName, y.CoreName, true);
        }
    }
}
