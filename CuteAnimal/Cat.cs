using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        public string name { get; set; }
        public int energy { get; set; }
        public Mood moodStatus { get; set; }
        public Feed feedStatus { get; set; }


        public string GetName()
        {
            return name;
        }

        public int GetEnergy()
        {
            return energy;
        }
        
        public Mood GetMood()
        {
            return moodStatus;
        }

        public Feed GetFeed()
        {
            return feedStatus;
        }

        public void Sleep()
        {
            energy++;
        }
    }
}