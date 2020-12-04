using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Piece 
    {
        public string Name { get; set; }
        public string Composer { get; set; }

        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Piece> pieceList = new List<Piece>(); 

            for (int i = 0; i < n; i++)
            {
                //{piece}|{composer}|{key}
                string[] elements = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                pieceList.Add(new Piece { Name = elements[0], Composer = elements[1], Key = elements[2] });
            }

            string input = Console.ReadLine();

            while (input!="Stop")
            {
                string[] command = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string piece = command[1];
                switch (command[0])
                {
                    case "Add":
                        string conpos = command[2];
                        string key = command[3];
                        if (pieceList.Any(n => n.Name == piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            pieceList.Add(new Piece { Name = piece, Composer = conpos, Key = key });
                            Console.WriteLine($"{ piece} by { conpos} in { key} added to the collection!");
                        }

                        break;
                    case "Remove":
                        if (pieceList.Any(n => n.Name == piece))
                        {
                            Piece current = pieceList.FirstOrDefault(n => n.Name == piece);

                            pieceList.Remove(current);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! { piece} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string newKey = command[2];

                        if (pieceList.Any(n=>n.Name==piece))
                        {
                            Piece change = pieceList.FirstOrDefault(n => n.Name == piece);
                            Piece toRemove = change;
                            change.Key = newKey;
                            pieceList.Remove(toRemove);
                            pieceList.Add(change);
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! { piece} does not exist in the collection.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var piece in pieceList.OrderBy(n=>n.Name).ThenBy(c=>c.Composer))
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }
    }
}
