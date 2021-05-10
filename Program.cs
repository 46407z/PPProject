using System;
using System.Collections.Generic;

namespace PPProject
{
    public class Program
    {
        static void Main(string[] args)
        {
                            //Promenlivi za broq na obektite
            int galaxyCount = 0;
            int starCount = 0;
            int planetCount = 0;
            int moonCount = 0;
                            //Vuvejdam stoinosti na instanciite na klasovete ruchno zashtoto ne uspqh da nakaram List da proraboti
            Console.WriteLine("Add a galaxy: (name, type, age)");
            Galaxy galaxy = new Galaxy();
            galaxy.Name = Console.ReadLine();
            galaxy.Type = Console.ReadLine();
            galaxy.Age = Console.ReadLine();
            galaxyCount++;

            Console.WriteLine("Add a star: (name, classification, mass, size, temperature, luminosity)");
            Star star = new Star();
            star.Name = Console.ReadLine();
            star.Classification = Console.ReadLine();
            star.Mass = Console.ReadLine();
            star.Size = Console.ReadLine();
            star.Temperature = Console.ReadLine();
            star.Luminosity = Console.ReadLine();
            starCount++;

            Console.WriteLine("Add a planet: (name, type, isItHabitable)");
            Planet planet = new Planet();
            planet.Name = Console.ReadLine();
            planet.Type = Console.ReadLine();
            planet.IsItHabitable = Console.ReadLine();
            planetCount++;

            Console.WriteLine("Add a moon: (name)");
            Moon moon = new Moon();
            moon.Name = Console.ReadLine();
            moonCount++;

                                                            //List test
            /*var galaxyElements = new List<object>
            {
                new Galaxy() {Name = Console.ReadLine(), Type = Console.ReadLine(), Age = Console.ReadLine()},
                new Star() {Name = Console.ReadLine(), Classification = Console.ReadLine(), Mass = Console.Read(), Size = Console.Read(), Temperature = Console.Read(), Luminosity = Console.Read() },
                new Planet() {Name = Console.ReadLine(), Type = Console.ReadLine(), IsItHabitable = Console.ReadLine()},
                new Star() {Name = Console.ReadLine()}
            };*/

                                    //Kakvo da se izkara v konzolata pri vuvedenata kluchova duma
            Console.WriteLine();
            string nextCommand = Console.ReadLine();
            if (nextCommand.Equals("stats"))
            {
                Stats(galaxyCount, starCount, planetCount, moonCount);
            }
            else if (nextCommand.Equals("list galaxies"))
            {
                Console.WriteLine(galaxy.Name);
            }
            else if (nextCommand.Equals("print " + galaxy.Name))
            {
                PrintMilkyWay(galaxy, star, planet, moon);
            }
            else if (nextCommand.Equals("exit"))
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine();

            string nextCommand2 = Console.ReadLine();
            if (nextCommand2.Equals("stats"))
            {
                Stats(galaxyCount, starCount, planetCount, moonCount);
            }
            else if (nextCommand2.Equals("list galaxies"))
            {
                Console.WriteLine(galaxy.Name);
            }
            else if (nextCommand2.Equals("print " + galaxy.Name))
            {
                PrintMilkyWay(galaxy, star, planet, moon);
            }
            else if (nextCommand.Equals("exit"))
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine();

            string nextCommand3 = Console.ReadLine();
            if (nextCommand3.Equals("stats"))
            {
                Stats(galaxyCount, starCount, planetCount, moonCount);
            }
            else if (nextCommand3.Equals("list galaxies"))
            {
                Console.WriteLine(galaxy.Name);
            }
            else if (nextCommand3.Equals("print " + galaxy.Name))
            {
                PrintMilkyWay(galaxy, star, planet, moon);
            }
            else if (nextCommand3.Equals("exit"))
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine();

            string nextCommand4 = Console.ReadLine();
            if (nextCommand4.Equals("stats"))
            {
                Stats(galaxyCount, starCount, planetCount, moonCount);
            }
            else if (nextCommand4.Equals("list galaxies"))
            {
                Console.WriteLine(galaxy.Name);
            }
            else if (nextCommand4.Equals("print " + galaxy.Name))
            {
                PrintMilkyWay(galaxy, star, planet, moon);
            }
            else if (nextCommand4.Equals("exit"))
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine();

        }

                                    //Metodi za printirane na dannite na obektite
        public static void PrintMilkyWay(Galaxy galaxy, Star star, Planet planet, Moon moon)
        {
            Console.WriteLine("---Data for " + galaxy.Name + " galaxy");
            Console.WriteLine(galaxy.Type);
            Console.WriteLine(galaxy.Age);
            Console.WriteLine("Stars:");
            PrintStarInfo(star);
            Console.WriteLine("Planets: ");
            PrintPlanetInfo(planet);
            PrintMoonInfo(moon);
            Console.WriteLine("---End of data for " + galaxy.Name + " galaxy");
        }
        public static void PrintMoonInfo(Moon moon)
        {
            Console.WriteLine(moon.Name);
        }
        public static void PrintPlanetInfo(Planet planet)
        {
            Console.WriteLine("Name: " + planet.Name);
            Console.WriteLine("Type: " + planet.Type);
            Console.WriteLine("Supports life: " + planet.IsItHabitable);

        }
        public static void PrintStarInfo(Star star)
        {
            Console.WriteLine("Name: " + star.Name);
            Console.WriteLine("Class: " + star.Classification + " [" + star.Mass + ", " + star.Size + ", " + star.Temperature + ", " + star.Luminosity + "]");
        }
        public static void PrintGalaxyInfo(Galaxy galaxy)
        {
            Console.WriteLine("Name: " + galaxy.Name);
            Console.WriteLine("Type: " + galaxy.Type);
            Console.WriteLine("Age: " + galaxy.Age);
        }

        public static void Stats(int galaxyCount, int starCount, int planetCount, int moonCount)
        {
            Console.WriteLine("---Stats---");
            Console.WriteLine("Galaxies: " + galaxyCount);
            Console.WriteLine("Stars: " + starCount);
            Console.WriteLine("Planets: " + planetCount);
            Console.WriteLine("Moons: " + moonCount);
            Console.WriteLine("---End of stats---");
        }

    }
    
}