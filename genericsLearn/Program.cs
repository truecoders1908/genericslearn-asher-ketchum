using System;
using System.Collections.Generic;

namespace genericsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag<char> scrabbleLetters = new Bag<char>();                // The List Bag returns a char is being defined as scrabbleLetters 
                                                                        // scrabbleLetters placed inside bag
            scrabbleLetters.PutItemIntoBag('q');                        // Bag<char> == q
            scrabbleLetters.PutItemIntoBag('j');                        // Bag<char> == j
            scrabbleLetters.PutItemIntoBag('z');                        // Bag<char> == z
            scrabbleLetters.PutItemIntoBag('y');                        // Bag<char> == y
            scrabbleLetters.PutItemIntoBag('x');                        // Bag<char> == x
            char letterFromBag = scrabbleLetters.GetItemFromBag();      // Defines Letter from bag as scrabbleLetters method GetItemFromBag [line 31]
            Console.WriteLine(letterFromBag);                           // Console displaces a random scrabble piece from bag using the list (q,j,z,y,x)
        }
    }

    class Bag<T>                                                        // New Class: Bag -- being defined as T
    {
        private List<T> items = new List<T>();                          //[private] is only going to be shared inside this nest thats creating a new bag list instance

        public void PutItemIntoBag(T item)                              // New Method: public void PutItemIntoBag(T item) 
                                                                        // ***Bag = T*** 
        {
            items.Add(item);                                            // 
        }

        public T GetItemFromBag()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, items.Count);
            T randomItem = items[randomIndex];
            items.RemoveAt(randomIndex);
            return randomItem;
        }
    }
}