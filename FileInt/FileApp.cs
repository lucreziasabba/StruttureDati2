using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInt
{
    class FileApp
    {
        private const string file = "file.txt";
        private const string file2 = "finito.txt";
        static void Main(string[] args)
        {
            HashSet<int> numeri = new HashSet<int>();
            using (StreamReader x = new StreamReader(file, Encoding.UTF8))
            {
                string line;
                while ((line = x.ReadLine()) != null)
                {
                    int n = int.Parse(line);
                    numeri.Add(n);
                }
            }
            using (StreamWriter f = new StreamWriter(file2, false))
            {
                foreach (int d in numeri)
                    f.WriteLine(d);
            }
        }
    }
}
