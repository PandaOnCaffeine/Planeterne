namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crates a list of the datatype Planet
            List<Planet> planets = new List<Planet>();
            
            //Creates the planets as objekts
            Planet mercury = new Planet("Mercury",4879,167);
            Planet venus = new Planet("Venus", 12104, 464);
            Planet earth = new Planet("Earth", 12756, 15);
            Planet mars = new Planet("Mars", 6792, -65);
            Planet jupiter = new Planet("Jupiter", 142984, -110);
            Planet saturn = new Planet("Saturn", 120536, -140);
            Planet uranus = new Planet("Uranus", 51118, -195);
            Planet neptune = new Planet("Neptune", 49528, -200);
            Planet pluto = new Planet("Pluto", 2370, -225);

            //Adds the planets to the list
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            //Writes out the planets list
            Console.WriteLine("Opg 1");
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name);
            }
            //inserts venus on the lists index 1
            planets.Insert(1,venus);

            //Writes out planets list
            Console.WriteLine("\r\n");
            Console.WriteLine("Opg 2");
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name);
            }

            //removes pluto from the list 
            planets.Remove(pluto);


            //writes out the planets list
            Console.WriteLine("\r\n");
            Console.WriteLine("opg 3");
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name);
            }

            //Adds pluto back
            planets.Add(pluto);

            //Writes out the planets list
            Console.WriteLine("\r\n");
            Console.WriteLine("opg 4");
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name);
            }

            //writes out how mant objekts there are in the list planets
            Console.WriteLine("\r\n");
            Console.WriteLine("Opg 5");
            Console.WriteLine(planets.Count);


            //creates a new list
            List<Planet> planetTemperature = new List<Planet>();

            //add all objekts with a temperature less then 0 to the planetTemperature list
            foreach (Planet p in planets)
            {
                if (p.Temperature < 0)
                {
                    planetTemperature.Add(p);
                }
            }

            //Writes out the planetTemperature list
            Console.WriteLine("\r\n");
            Console.WriteLine("Opg 6");
            foreach (Planet p in planetTemperature)
            {
                Console.WriteLine(p.Name);
            }

            //creates a new list again
            List<Planet> planetsDiameter = new List<Planet>();

            //adds all objekts from the list planets with a diameter bigget then 10000 and less then 50000 to the new list planetsDiameter
            foreach (Planet p in planets)
            {
                if (p.Diameter > 10000 && p.Diameter < 50000)
                {
                    planetsDiameter.Add(p);
                }
            }

            //writes out the planetsDiameter list
            Console.WriteLine("\r\n");
            Console.WriteLine("Opg 7");
            foreach (Planet p in planetsDiameter)
            {
                Console.WriteLine(p.Name);
            }

            //Clears the planets list and writes it out
            Console.WriteLine("\r\n");
            Console.WriteLine("Opg 8");
            planets.Clear();
            foreach (Planet p in planets)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}