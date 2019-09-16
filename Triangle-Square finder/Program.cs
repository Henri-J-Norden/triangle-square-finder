using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Triangle_Square_finder {
    class Program {
        static void Main(string[] args) {
            long n = 0;
            long m = 0;
            StreamWriter file = new StreamWriter("triangle-square.txt");
            while (true) {
                double n2 = 2 * Math.Pow(n, 2);
                while (Math.Pow(m, 2) + m < n2) {
                    m++;
                }
                if (Math.Pow(m, 2) + m == n2) {
                    Console.WriteLine((n2 / 2).ToString("N0") + " = " + n + "^2 = (" + m + "^2 + " + m + ") / 2");
                    file.WriteLine(Math.Pow(n, 2).ToString("N0") + " = " + n + "^2 = (" + m + "^2 + " + m + ") / 2");
                    file.WriteLine("n = " + n.ToString("N0"));
                    file.WriteLine("m = " + m.ToString("N0"));
                    file.WriteLine("num = " + (n2 / 2).ToString("N0"));
                    file.Flush();
                }
                n++;
            }
        }
    }
    
}
