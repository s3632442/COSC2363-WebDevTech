using StructsVsClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StructsVsClasses
{
    public class TestStructVsClass
    {

        public TestStructVsClass()
        {
            //Class = Pass by Ref
            //does support inheritance

            //StructsVsClasses.Classes.Dog fido = new StructsVsClasses.Classes.Dog("Fido");
            //StructsVsClasses.Classes.Dog rex = new StructsVsClasses.Classes.Dog("Rex");

            //Console.WriteLine(fido.Name);
            //Console.WriteLine(rex.Name);
            ////pass by ref means that rex mem is now lost and is pointing to fido
            //rex = fido;
            //Console.WriteLine(fido.Name);
            //Console.WriteLine(rex.Name);
            ////now when renaming rex we are renaming the same mem location for fido
            //rex.Name = "Thai";
            //Console.WriteLine(fido.Name);
            //Console.WriteLine(rex.Name);


            //Structs = Pass by Value
            //does not support inheritance
            StructsVsClasses.Structs.Dog fido = new StructsVsClasses.Structs.Dog("Fido");
            StructsVsClasses.Structs.Dog rex = new StructsVsClasses.Structs.Dog("Rex");

            Console.WriteLine(fido.Name);
            Console.WriteLine(rex.Name);
            //pass by ref means that rex mem is now lost and is pointing to fido
            rex = fido;
            Console.WriteLine(fido.Name);
            Console.WriteLine(rex.Name);
            //now when renaming rex we are renaming the same mem location for fido
            rex.Name = "Thai";
            Console.WriteLine(fido.Name);
            Console.WriteLine(rex.Name);
        }

    }
}
