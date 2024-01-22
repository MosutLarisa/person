using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class People
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime YearOfBirth { get; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - YearOfBirth.Year;
            }
        }


    }
}
