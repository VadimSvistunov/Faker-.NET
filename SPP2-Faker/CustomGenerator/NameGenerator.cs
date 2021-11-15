using System;
using System.Collections.Generic;
using Generator.SDK;

namespace CustomGenerator
{
    public class NameGenerator:IGenerator {

        public Type Type => typeof(string);        
        private readonly Random _random = new();
        private readonly List<string> _names;

        public NameGenerator()
        {
            _names = new List<string>() {
                "Dasha", "Anna", "Polina", "Alice", "Alesya", "Nastya", "Nazar", "Vlad" 
            };
        }
        
        public object Generate() {
            return _names[_random.Next(_names.Count)];
        }
    }
}