using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp4
{
    public class Info
    {
        public string name;
        public int count;

        public Info(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public override string ToString()
        {
            return $"{name}(count:{count})";
        }
    }
    public class Logs
    {
        public string name;
        public int size;

        public List<Info> infos;

        public Logs(string name, int size)
        {
            this.name = name;
            this.size = size;
            infos = new List<Info>();
        }
        public override string ToString()
        {
            string t = $"{name}(size:{size})" + "{" + Environment.NewLine;
            foreach (var item in infos)
            {
                t += "\t" + item + Environment.NewLine;
            }
            t += "}" + Environment.NewLine;
            return t;
        }

        public int sumc()
        {
            int s = 0;
            foreach (var item in infos)
            {
                s += item.count;
            }
            return s;
        }
    }
}
