using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bs = new BaseClass();
            bs.Method();
            bs = new SomeCLass();
            bs.Method();
            Console.ReadLine();
        }
    }
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Hello world");
        }
    }
    class SomeCLass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Hello Gleb");
        }
    }
}
