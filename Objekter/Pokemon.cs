using System;

namespace Pokedex
{
    internal class Pokemon
    {
     
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Level { get; set; }
        public string Health { get; set; }

        public Pokemon(string name, string type, string gender, string level, string health)
        {
            Name = name;
            Type = type;
            Gender = gender;
            Level = level;
            Health = health;
        }
        
    }
}
