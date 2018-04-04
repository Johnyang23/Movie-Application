using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Yang_Movieapp
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string birth;
        private string info;

        public Person ()
        {

        }

        public Person(string firstName, string lastName, string Birth, string Info )
        {
            firstname = firstName;
            lastname = lastName;
            birth = Birth;
            info = Info;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public override string ToString()
        {
            return "\nFirst name: " + firstname + "\nLast Name: " + lastname + "\nDate of birth: " + birth + "\nBio: " + info;

        }
    }
}
