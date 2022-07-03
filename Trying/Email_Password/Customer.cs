using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying
{
    public class Customer : MyServer
    {
        
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            
        }

        private string PasswordM()
        {
            string password = "";
            for (int i = 0; i < 9; i++)
            {
                Random R = new Random();
                int item = R.Next(41, 123);
                //pass[i] = ((char)(item));
                password += ((char)(item));
            }
            return password;
        }

        public override void CreatPassword()
        {

            if (check())
            {
                Console.WriteLine("");
                Console.WriteLine($"Thanks {Name}.  Your email is correct \n Created Password is => {PasswordM()}");
            }
            else
            {
                Console.WriteLine($"Sorry {Name} , Your email is not correct ! ");
            }
        }

    }
}
