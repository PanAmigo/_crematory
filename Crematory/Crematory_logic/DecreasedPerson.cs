using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class DecreasedPerson
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateOfDeath { get; private set; }
        public int Status { get; private set; }
        public int ColdRoom { get; private set; }
        public string OtherDetails { get; private set; }

        public DecreasedPerson(string name, int age, DateTime dateOfBirth, DateTime dateOfDeath, int status, int coldRoom, string otherDetails)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            DateOfDeath = dateOfDeath;
            Status = status;
            ColdRoom = coldRoom;
            OtherDetails = otherDetails;
        }

        public DecreasedPerson(string name, int age, DateTime dateOfBirth, DateTime dateOfDeath, string otherDetails)
        {
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            DateOfDeath = dateOfDeath;          
            OtherDetails = otherDetails;
        }
    }
}
