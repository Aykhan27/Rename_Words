using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class DicFile
    {
        public string Name;
        public string path;

        public DicFile(string path)
        {
            this.path = path;
            Name = Path.GetFileNameWithoutExtension(path);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
