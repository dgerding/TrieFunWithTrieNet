using Gma.DataStructures.StringSearch;
using System;
using System.Diagnostics;
using System.IO;

namespace TrieHouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 0;

            Trie<int> trie = new Trie<int>();
            using (var streamReader = File.OpenText(@"words.txt"))
            {



                while (!streamReader.EndOfStream)
                {
                    string check = streamReader.ReadLine();
                    if (!string.IsNullOrEmpty(check))
                    {
                        trie.Add(check, x);

                        x++;
                    }

                }

            }

            var get = trie.Retrieve("the");

            Debug.WriteLine("DONE LOADING TREE" + DateTime.UtcNow.ToString());

        }
    }
}
