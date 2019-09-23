using System;
using System.Collections.Generic;

namespace genericsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag<char> scrabbleLetters = new Bag<char>();                // Creating a new instance of Bag named scrabbleLetters
            scrabbleLetters.PutItemIntoBag('q');                        // scrabbleLetters == q
            scrabbleLetters.PutItemIntoBag('j');                        // scrabbleLetters == j
            scrabbleLetters.PutItemIntoBag('z');                        // scrabbleLetters == z
            scrabbleLetters.PutItemIntoBag('y');                        // scrabbleLetters == y
            scrabbleLetters.PutItemIntoBag('x');                        // scrabbleLetters == x
            char letterFromBag = scrabbleLetters.GetItemFromBag();      // Defines scrabbleLetters method GetItemFromBag [line 31] as letterFromBag
            Console.WriteLine(letterFromBag);                           // Console will display a random scrabble piece from bag using the list (q,j,z,y,x)
        }
    }

    class Bag<T>                                                        // New Class: Bag with <T> being used as a place holder
    {
        private List<T> items = new List<T>();                          //[private] is only going to be shared inside this nest thats creating a new bag list instance

        public void PutItemIntoBag(T item)                              // New Method: public void PutItemIntoBag(T item) 
                                                                        // ***Bag = T*** 
        {
            items.Add(item);                                            // item is being placed into the bag 
        }

        public T GetItemFromBag()                                      // Method to get items from bag
        {
            Random rnd = new Random();                                 // Random Functionality to grab random scrabble letter
            int randomIndex = rnd.Next(0, items.Count);                // Counts amount of items inside bag
            T randomItem = items[randomIndex];                         // Creating a variable random that equals randomindex
            items.RemoveAt(randomIndex);                               // Removes Letter from the Bag
            return randomItem;                                         // Random item that was grabbed from bag then will be displayed on Console.WriteLine [Line 17]
        }
    }
}                                                                       ////