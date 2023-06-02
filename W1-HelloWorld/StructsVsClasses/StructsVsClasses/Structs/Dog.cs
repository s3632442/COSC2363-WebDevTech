using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsVsClasses.Structs
{
    public struct Dog
    {

        private string _name;

        public Dog(string name)
        {

            _name = name;

        }


        public string Name
        {

            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }

        public string Description() => "Hello my name is: " + Name;

    }
}
