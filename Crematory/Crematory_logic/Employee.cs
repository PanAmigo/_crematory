using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crematory_logic
{
    public class Employee
    {
        //
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Other_details { get; private set; }

        public Employee(string name, string surname, string phone, string email, string other_details)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Other_details = other_details;
        }

    }
}
