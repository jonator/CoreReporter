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
    class Core
    {
        string coreName;
        long size;
        int documentCount;

        public Core(string CoreName, long Size, int DocumentCount)
        {
            coreName = CoreName;
            size = Size;
            documentCount = DocumentCount;
        }

        public string CoreName { get { return coreName; } }
        public long Size { get { return size; } }
        public int Document { get { return documentCount; } }
    }
}
