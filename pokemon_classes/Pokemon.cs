using System;

namespace pokemon_classes
{
    class Pokemon
    {
        public string name;
        public string pokeType;
        public string weaknesses;
        public string resistance;
        public int HP;

        //static void Main()
        //{
        //    Console.WriteLine("test");
        //}

        //public void greeting(string name)
        //{
        //    Console.WriteLine(name + " " + name);
        //}

        //public void greeting(string name, int hp)
        //{
        //    Console.WriteLine(name + " " + name);
        //    Console.WriteLine("HP: " + hp);
        //}

        public virtual void greeting(string name)
        {
            this.name = name;
            Console.WriteLine(name + " " + name);
        }


    } // end of pokemon class

    class Water: Pokemon
    {
        public string weakness1;
        public string weakness2;

        //constructor
        public Water()
        {
            pokeType = "water";
            weakness1 = "Grass";
            weakness2 = "Electric";
        }
        public override void greeting(string name)
        {
            Console.WriteLine("Greeting: water water");
        }


    }

    class Pokedex
    {
        static void Main(string[] args)
        {
            Water squirtle = new Water();
            squirtle.name = "Squirtle";
            squirtle.HP = 100;

            Console.WriteLine("Name: " + squirtle.name);
            Console.WriteLine("Type: " + squirtle.pokeType);

            squirtle.greeting(squirtle.name);
            Console.WriteLine("Weaknesses: " + squirtle.weakness1 + " and " + squirtle.weakness2);

        }
    }
}
