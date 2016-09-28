using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDSLK
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(6);
            Element<int> b = new Element<int>(45);
            Element<int> c = new Element<int>(3);
            List<int> demo = new List<int>();
            demo.addfirst(a);
            demo.addfirst(b);
            demo.addfirst(c);
            demo.printList();
            Element<string> d = new Element<string>("neko");
            Element<string> e = new Element<string>("inu");
            List<string> demo2 = new List<string>();
            demo2.addfirst(d);
            demo2.addfirst(e);
            demo2.printList();
            Console.ReadKey();
            }
    }
}
