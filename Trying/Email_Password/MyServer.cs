using System.Text.RegularExpressions;

namespace Trying
{
    public abstract class MyServer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public abstract void CreatPassword();

        protected bool check()
        {
            
            Regex E = new Regex("^[a-z0-9(.)(_)]{8,30}\\@[a-z]{4,8}\\.(com)$");
            return ( E.IsMatch(Email) ?  true : false );
        }

    }
}
