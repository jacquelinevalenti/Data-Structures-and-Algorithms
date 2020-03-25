using System;

namespace CaesarCyphers
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
            Console.ReadLine();
        }
        public static void MainMenu()
        {
            CaesarCypher cc = new CaesarCypher();

            Console.WriteLine("Choose an option for the Caesar Cypher: ");
            Console.WriteLine("1: Encode text");
            Console.WriteLine("2: Decode text with key");
            Console.WriteLine("3: Decode text without key");
            Console.WriteLine("4: Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    string encodedText = cc.Encode(EnterPhrase(), EnterKey());
                    Console.WriteLine($"The encoded text is: \n{encodedText}\n");
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    string decodedText = cc.Decode(EnterPhrase(), EnterKey());
                    Console.WriteLine($"The decoded text is: \n{decodedText}\n");
                    MainMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter the phrase to be run through the Caesar Cypher: ");
                    string userInput = Console.ReadLine();
                    Console.WriteLine("The following are the potential decoded cyphers:");
                    for (int i = 0; i < 27; i++)
                    {
                        string decodedTextNoKey = cc.Decode(userInput, i);
                        Console.WriteLine($"\n{decodedTextNoKey}\n");
                    }
                    MainMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        public static string EnterPhrase()
        {
            Console.WriteLine("Enter your phrase to be run through the Caesar Cypher: ");
            string userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }
        public static int EnterKey()
        {
            Console.WriteLine("Enter your key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return key;
        }
    }

    public class CaesarCypher
    {
        public char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public string Encode(string userInput, int key)
        {
            string output = string.Empty;
            foreach (char ch in userInput)
            {
                output += Cipher(ch, key);
            }
            return output;
        }
        public string Decode(string userInput, int key)
        {
            return Encode(userInput, 26 - key);
        }

    }
}

