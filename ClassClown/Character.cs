using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassClown
{
    internal class Character
    {
        // Fields
        private string name;
        private string phrase1;
        private string phrase2;
        private int level = 0;

        // Constructor
        public Character(string Name, string Phrase1, string Phrase2)
        {
            name = Name;
            phrase1 = Phrase1;
            phrase2 = Phrase2;
        }
        
        // Methods
        public void Speak(int phraseNum)
        {
            //Console.WriteLine($"Lvl.{this.level} {this.name}:\"{this.phrase1}\"");
            if (phraseNum == 1)
            {
                Console.WriteLine($"Lvl.{this.level} {this.name}:\"{this.phrase1}\"");
            }
            else if (phraseNum == 2)
            {
                Console.WriteLine($"Lvl.{this.level} {this.name}:\"{this.phrase2}\"");
            }
        }

        public void SetLevel(int newLevel)
        {
            this.level = newLevel;
        }
    }
}