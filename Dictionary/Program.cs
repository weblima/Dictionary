using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, int> names = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votos = int.Parse(line[1]);

                        if (names.ContainsKey(name)) {
                            names[name] += votos;
                        }
                        else {
                            names[name] = votos;
                        }
                        
                    }
                }

                foreach (KeyValuePair<string, int> item in names) {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
