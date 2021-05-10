using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPProject
{
    public class Planet : Program
    {
        public string name;
        public string type;            //terrestrial, giant planet, ice giant, mesoplanet, mini-neptune, planetar, super-earth, super-jupiter, sub-earth.
        public string isItHabitable;


        //Contructors
        public Planet() { }
        public Planet(string name)
        {
            this.name = name;
        }
        public Planet(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public Planet(string name, string type, string isItHabitable)
        {
            this.name = name;
            this.type = type;
            this.isItHabitable = isItHabitable;
        }


        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string IsItHabitable
        {
            get { return isItHabitable; }
            set { isItHabitable = value; }
        }
    }
}
