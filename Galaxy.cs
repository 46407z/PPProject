using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPProject
{
    public class Galaxy : Program
    {
        private string name;
        private string type;            //eliptical, lenticular, spiral, irregular
        private string age;             //float with B(illion) or M(illion) at the end


        //Constructors
        public Galaxy() { }
        public Galaxy(string name)
        {
            this.name = name;
        }
        public Galaxy(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public Galaxy(string name, string type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
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
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
