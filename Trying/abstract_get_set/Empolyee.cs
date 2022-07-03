using System;

namespace Trying
{
    class Empolyee : Person
    {
        
        public override string DataP 
        {
            get { return $"{name}  {age}"; }
            set { name = value;} 
        }

        public override void all()
        {
            name = "sa";
            age = 50;
            Console.WriteLine($"Name : {DataP} ,");
        }

        public void who(string name)
        {
            Console.WriteLine("Employee " + name);
            
        }
        
    }


}
