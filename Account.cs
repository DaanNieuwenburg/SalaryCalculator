using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set;}
        public string Bedrijf { get; set; }

        public override string ToString()
        {
            return String.Format(Username,Password,Voornaam,Achternaam,Bedrijf);
        }
    }
    
}
