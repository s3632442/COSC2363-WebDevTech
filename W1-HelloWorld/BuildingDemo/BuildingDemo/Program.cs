using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDemo
{
    internal class Program
    {
        static void Main()
        {

            Building house = new Building(4, 2500, 2);
            Building office = new Building(25, 4200, 3);


            Console.WriteLine($@"house has: 
    {house.Floors} floors
    {house.Area} floor space
    and can house
    {house.Occupants} occupants");

            Console.WriteLine(house.AreaPerPerson());

            Console.WriteLine($@"office has: 
    {office.Floors} floors
    {office.Area} floor space
    and can office
    {office.Occupants} occupants");

            Console.WriteLine(office.AreaPerPerson());

        }

    }
}
