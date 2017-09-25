using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这是创建github使用的");
            person p = new person();
            p.age = 21;
            Student s = new Student();
            s.name = "hello";
        }
    }

    public class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
