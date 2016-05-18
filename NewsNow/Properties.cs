using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsNow
{
    class Properties
    {



        public Dictionary<string, string> LoadProperties()
        {
            FileStream fs = new FileStream(News.path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Dictionary<string, string> properties = new Dictionary<string, string>();

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] elems = line.Split('=');
                properties.Add(elems[0], elems[1]);
            }
            fs.Close();
            return properties;
        }
    }
}
