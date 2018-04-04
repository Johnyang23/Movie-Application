using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Yang_Movieapp
{
    class Cast : Person
    {
        private string character;
        
        public Cast ()
        {

        }

        public Cast ( string Character, string firstname, string lastname, string birth, string info) : base (firstname,lastname, birth, info)
        {
            character = Character;
        }

        public string Character
        {
            get
            {
                return character;
            }
            set
            {
                character = value;
            }
        }

        public override string ToString()
        {
            return character;
        }


    }
}
