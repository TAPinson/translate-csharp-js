using System;
using System.Collections.Generic;

namespace dinner_party
{
    class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }

        public string Bio { get; set; }

        public void AddName(string suppliedName)
        {
            Name = suppliedName;
        }

        public void AddOccupation(string suppliedOccupation)
        {
            Occupation = suppliedOccupation;
        }

        public void AddBio(string suppliedBio)
        {
            Bio = suppliedBio;
        }
    }
}
