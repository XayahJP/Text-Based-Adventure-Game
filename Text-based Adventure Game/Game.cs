using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShikaAdventureGame
{
    public class Game
    {
        public int strength = 1;
        public int luck = 0;

        public static void AddStrengthSword()
        {
            int Strength = 2; //Could not figure out how to make strength work from the class Game and use it in CharacterDecisions
        }

        public static void CharacterName()
        {
            Console.WriteLine("Please state your name, young adventurer! You must hurry! There's no time to explain! You were unconcious, but the fate of this world is up to you!\n");
            string input = Console.ReadLine();
        }

        public static void StartGame()
        {
            Console.Title = "Shika's Adventure Game";

            CharacterName();

            Console.WriteLine("\nI can't believe you fell for that! I'll just call you 'young one' to annoy you." +
                "\nAnyway, there's a camp to the north along the Anora River. Figure something out kid.\n");
        }

        public static void StartGameAgain()
        {
            Console.WriteLine("Let's hope you have a brain this time. You've awakened yada yada yada... You know the deal.\n");
            DecisionsArray.Choice1();
        }

        public static void EndGame()
        {
            Console.WriteLine("Congratulations! Thanks to you, this world can finally have peace. Your name will not be forgotte-- I forget what your name was...");
        }
    }
}