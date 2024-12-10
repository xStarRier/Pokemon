using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class App
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
        public string Health { get; set; }

        List<Pokemon> pokemon = new List<Pokemon>()
       {
           new Pokemon("Bulbasaur", "Grass", "Female", "30", "30"),
           new Pokemon("Pikachu", "Electric", "male","3" , "10"),
           new Pokemon("Gengar", "Ghost", "Male", "40", "20")
       };
     
         public void Run()
         {
            bool running = true;
            while (running)
            { 
            Console.Clear();
            Console.WriteLine("1. See Pokemon");
            Console.WriteLine("1. to catch Bulbasaur ");
            Console.WriteLine("2. to catch Pikachu ");
            Console.WriteLine("3. to catch Gengar");
            Console.WriteLine("5. Add another pokemon to the Pokedex");
                var input = Console.ReadLine();
            
           
        


            switch (input)
            {
                case "1":
                    ShowPokemon();
                    break;
                case "2":
                    Console.WriteLine($"You have catched Bulbasaur");
                    break;
                case "3":
                    Console.WriteLine("You have catched Pikachu");
                    break;
                case "4":
                    Console.WriteLine("You have catched Gengar");
                    break;
                case "5":
                   AddPokemon();
                     break;
             
              }    
            }        
            
        
         }
         public void ShowPokemon()
         {
            
            Console.Clear();
            Console.WriteLine("Pokedex has been activated!\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (var pokemon in pokemon)
            {
               Console.WriteLine($"Name: {pokemon.Name} ");
               Console.WriteLine($"Type: {pokemon.Type}* Gender: {pokemon.Gender}* Health: {pokemon.Health}* Level: {pokemon.Level}* ");
               Console.WriteLine("------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("Press Any Button To Go Back");
            Console.ReadLine();
         }
        public void AddPokemon()
        {
            
            Console.WriteLine("Pokemon Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Type: ");
            Type = Console.ReadLine();

            Console.WriteLine("Gender: ");
            Gender = Console.ReadLine();

            Console.WriteLine("Health: ");
            Health = Console.ReadLine();

            Console.WriteLine("Level: ");
            Level = Console.ReadLine();

            pokemon.Add(new Pokemon(Name, Type, Gender, Health, Level));
             
            
        }
        public void ShowNewset()
        {
            Console.WriteLine("Added a new Pokemon!\n");

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            foreach (var pokemon in pokemon)
            {
                Console.WriteLine($"Name: {pokemon.Name} ");
                Console.WriteLine($"Type: {pokemon.Type}* Gender: {pokemon.Gender}* Health: {pokemon.Health}* Level: {pokemon.Level}* ");
                Console.WriteLine("------------------------------------------------------------------------------------------------");

            }
        }



    }
}
