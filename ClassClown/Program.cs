using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassClown // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Character Class stuff
            // Init Character Objects
            Character char1 = new Character("Patrick Bateman", "Look at paul allen's card", "why not you stupid [censored]");
            Character char2 = new Character("Mario", "Wahoo", "I'm christ pratt");

            // Test Character functionality
            char1.Speak(1);
            char2.SetLevel(5);
            char2.Speak(2);

            // Backpack Class Stuff
            // Init Backpack Objects
            Backpack bkpk1 = new Backpack("blue", "small");
            Backpack bkpk2 = new Backpack("red", "medium");
            Backpack bkpk3 = new Backpack("green", "large");

            // Test Backpack functionality
            bkpk1.OpenBag();
            bkpk1.PutIn("lunch");
            bkpk1.PutIn("jacket");
            bkpk1.CloseBag();
            bkpk1.OpenBag();
            bkpk1.TakeOut("jacket");
            bkpk1.CloseBag();

        }
    }
}