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
    class CoreDocumentCountComparer
    {
        public int Compare(Core x, Core y)
        {
            if (x.Document < y.Document)
                return -2;
            else if (x.Document > y.Document)
                return 2;
            else
                return 0;
        }
    }
}
