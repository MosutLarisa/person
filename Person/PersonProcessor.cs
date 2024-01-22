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

                People oldest = people[0];

                foreach (People person in people)
                {
                    if (person.Age > oldest.Age)
                    {
                        oldest = person;
                    }
                }

                return oldest;
            
        }
    }
}
