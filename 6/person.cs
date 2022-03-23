using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class person
    {
        private string name = null;
        private string profession = null;
        private string position = null;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Profession
        {
            get
            {
                return this.profession;
            }
            set
            {
                this.profession = value;
            }
        }
        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
        public person(string[] input)
        {
            name = input[0];
            profession = input[1];
            position = input[2];
        }
    }
}
