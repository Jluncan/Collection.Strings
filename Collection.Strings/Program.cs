using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Collection.Strings {
    internal class Program {
        static void Main(string[] args) {

            /*


            List<string> strings = new List<string>();

            strings.Add("Pink");
            strings.Add("Red");
            strings.Add("Magenta");
            strings.Add("Burgundy");
            strings.Add("Black");

            strings.AddRange(new string[] { "Green", "Yellow" });

            Console.Write("Enter your color here");
            var color = Console.ReadLine();
            if (strings.Contains(color)) {
                Console.WriteLine("color already exists!");
            } else {
                strings.Add(color);
                Console.WriteLine("Color added");
            }
                }
                }
         */


          

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(22, "Twenty-two");
            dictionary.Add(14, "Fourteen");

            Console.WriteLine(dictionary[22]); 

        }
    }
}
