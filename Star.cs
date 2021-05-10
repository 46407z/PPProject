using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPProject
{
    public class Star : Program
    {
        private string name;
        private string classification;        //O, B, A, F, G, K, M
        private string mass;
        private string size;
        private string temperature;
        private string luminosity;

        


        //Constructors
        public Star() { }
        public Star(string name)
        {
            this.name = name;
        }
        public Star(string name, string classification)
        {
            this.name = name;
            this.classification = classification;
        }
        public Star(string name, string classification, string mass)
        {
            this.name = name;
            this.classification = classification;
            this.mass = mass;
        }
        public Star(string name, string classification, string mass, string size)
        {
            this.name = name;
            this.classification = classification;
            this.mass = mass;
            this.size = size;
        }
        public Star(string name, string classification, string mass, string size, string temperature)
        {
            this.name = name;
            this.classification = classification;
            this.mass = mass;
            this.size = size;
            this.temperature = temperature;
        }
        public Star(string name, string classification, string mass, string size, string temperature, string luminosity)
        {
            this.name = name;
            this.classification = classification;
            this.mass = mass;
            this.size = size;
            this.temperature = temperature;
            this.luminosity = luminosity;
        }


        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Classification
        {
            get { return classification; }
            set { classification = value; }
        }
        public string Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public string Mass
        {
            get { return mass; }
            set { mass = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Luminosity
        {
            get { return luminosity; }
            set { luminosity = value; }
        }
    }
}
