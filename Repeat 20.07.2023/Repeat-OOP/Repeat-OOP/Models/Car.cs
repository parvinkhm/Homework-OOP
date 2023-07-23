using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_OOP.Models
{
    internal class Car
    {
        public string Name { get; set; }

        protected string color;

        private int _speed;

        public int Speed { 
            get
            {
                if (_speed > 300)
                {
                    return _speed; 
                }

                return -1;

            } set
            {
                _speed = value;

}            }
    }
}
