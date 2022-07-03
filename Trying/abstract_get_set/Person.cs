using System;

namespace Trying
{
    public abstract class Person
    {

        public string name;
        public  int age;
        public abstract string DataP { get; set; }
        public abstract void all();
        void b() { Console.WriteLine("bos"); }


    }


}
