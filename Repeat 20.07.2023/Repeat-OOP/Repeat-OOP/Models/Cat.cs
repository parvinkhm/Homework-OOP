using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_OOP.Models
{
    internal class Cat
    {
        protected int age;
        

        public void Test()
        {
            Console.WriteLine("test1");
            Test2();
        }

        private void Test2()
        {
            Console.WriteLine("test2");
        }
    }
}
