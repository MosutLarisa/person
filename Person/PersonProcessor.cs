using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public static class PersonProcessor
    {
        public static People GetOldestPerson(People[] people)
        {

            People oldestPerson = people[0];

            foreach (var person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }
    }
}
