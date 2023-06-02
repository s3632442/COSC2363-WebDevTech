using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsVsClasses.Classes
{
    public class Dog
    {
        private string _name;

        public Dog(string name) { 
        
            Name = name;

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
