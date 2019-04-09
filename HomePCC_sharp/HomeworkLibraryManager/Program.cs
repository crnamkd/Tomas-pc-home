using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Classes;
using Type = Books.Classes.Type;


namespace HomeworkLibraryManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Library thousandBooks = new Library("Thousand Books");

            Novels ulysses = new Novels("James Joyce", "Ulysses", EditionType.Hardcover, 345, false);
            Novels theGreatGatsby = new Novels("F. Scott Fitzgerald", "The Great Gatsby", EditionType.EBook, 2222, false);
            Novels lolita = new Novels("Vladimir Nabokov", "Lolita", EditionType.AudioBook, 422, false);
            Novels catch22 = new Novels("Joseph Heller", "Catch 22", EditionType.Paperback, 356, false);
            Novels harryPoter = new Novels(" J. K. Rowling", "Harry Potter", EditionType.Hardcover, 4522, false);
            Novels harryPotterandtheHalfBloodPrince = new Novels("J.K. Rowling", "Harry Potter and the Half-Blood Prince", EditionType.Hardcover, 642, true);
            Novels harryPotterandTheGobletOfFire = new Novels("J.K. Rowling", "Harry Potter and the Goblet of Fire", EditionType.Hardcover, 922, true);
            Novels harryPoterAndTheChamberOfSeacret = new Novels("J.K. Rowling", "Harry Potter And The Chamber Of Seacret", EditionType.Hardcover, 399, true);
            harryPoter.AddToSeries(harryPoterAndTheChamberOfSeacret);
            harryPoter.AddToSeries(harryPotterandTheGobletOfFire);
            harryPoter.AddToSeries(harryPotterandtheHalfBloodPrince);

            StoryCollection sticks = new StoryCollection("Unknown", "Sticks", StoryType.ShortStory, true);
            StoryCollection victoryLap = new StoryCollection("Unknown", "Victory Lap", StoryType.Novellete, true);

            StoryCollections tenthOfDecember = new StoryCollections("George Saunders", "Tenth of December", EditionType.Paperback, 1244);
            tenthOfDecember.AddStory(sticks);
            tenthOfDecember.AddStory(victoryLap);

            Anthology fragileThings = new Anthology("Neil Gaiman", "fantastic", EditionType.Hardcover, 360, "Fragile Things");
            StoryAnthology closingTime = new StoryAnthology("Closing Time", "Robert Aickman", StoryType.ShortStory, true);
            StoryAnthology aLoveStory = new StoryAnthology("A Love Story", "Waren Pleece", StoryType.ShortStory, true);
            fragileThings.AddStory(closingTime);
            fragileThings.AddStory(aLoveStory);

            thousandBooks.AddBook(harryPoter);
            thousandBooks.AddBook(tenthOfDecember);
            thousandBooks.AddBook(fragileThings);
            var allBooks = thousandBooks.GetBooks();
            //------------------------------------------------------------------------------------

            string input = Console.ReadLine();
            



            if (input == "novela")
            {
                PrintNovela(allBooks);

            }
            Console.WriteLine("\n----------------");

            if (input == "coll")
            {
                PrintCollectionStory(allBooks);

            }
            Console.WriteLine("\n----------------");

            if (input == "ant")
            {
                PrintAnthology(allBooks);

            }
            Console.WriteLine("\n----------------");








            //------------------------------------------------------------------------------------
            //  Print
            PrintCollectionStory(allBooks);
            Console.WriteLine("\n----------------");
            Console.WriteLine("Anthology : \n");
            PrintAnthology(allBooks);
            Console.WriteLine("\n----------------");

            Console.WriteLine("Novelas : \n");
            PrintNovela(allBooks);
            Console.WriteLine("\n----------------");

            Console.ReadLine();
        }

        static void Print(List<IBook> books)
        {
            foreach (var book in books)
            {
                if (book.Type == Type.Novela)
                {
                    Console.WriteLine(book.ToString());
                }
                else if (book.Type == Type.Anthology)
                {
                    Console.WriteLine(book.ToString());
                }
                else if (book.Type == Type.StoryCollection)
                {
                    Console.WriteLine(book.ToString());
                };
            }
        }

        static void PrintNovela(List<IBook> book)
        {
            foreach (var nov in book)
            {
                if (nov.Type == Type.Novela)
                {
                    Console.WriteLine(nov.ToString());
                }
            }
        }
        static void PrintAnthology(List<IBook> book)
        {
            foreach (var ant in book)
            {
                if (ant.Type == Type.Anthology)
                {
                    Console.WriteLine(ant.ToString());
                }
            }
        }
        static void PrintCollectionStory(List<IBook> book)
        {
            foreach (var coll in book)
            {
                if (coll.Type == Type.StoryCollection)
                {
                    Console.WriteLine(coll.ToString());
                }
            }
        }








    }
}
