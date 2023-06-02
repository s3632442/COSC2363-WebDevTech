using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDemo
{
    public class Building
    {
        private int _floors;
        private int _area;
        private int _occupants;

        public Building(int floors, int area, int occupants) {
            Floors = floors;
            Area = area;
            Occupants = occupants;
        }

        public int Floors
        {
            get
            {
                return _floors;
            }
            set
            {  _floors = value;  }
        }
        public int Area
        {
            get
            {
                return _area;
            }
            set { _area = value; }
        }
        public int Occupants
        {
            get
            {
                return _occupants;
            }
            set { _occupants = value; }
        }

        public string AreaPerPerson()
        {
            string result = " " + Area / Occupants + " area per person";

            return result;
        }



    }


}
