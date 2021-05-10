using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPProject
{
    public class Moon
    {
        private string name;

        
        //Constructors
        public Moon() { }
        public Moon(string name)
        {
            this.name = name;
        }


        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
