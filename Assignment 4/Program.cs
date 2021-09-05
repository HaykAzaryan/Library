using System;

namespace Assignment_4
{
    class Program
    {
        static void Library()
        {

            Console.WriteLine("******************Welcome To Library******************\n");
            DayOfWeek day = new DayOfWeek();
            Library lb = new Library();
            var book = ("Harry Potter", "J.K. Rowling", 2007, "Fantasy Friction");
            Console.WriteLine($"Most Popular Book In This Library Is The Series Of {book.Item1}. Was Written By {book.Item2} In {book.Item3}. It is In {book.Item4} category\n");
            Console.WriteLine($"This Library Has {lb.NumOfSeats} Availible Seats And {lb.NumOfBooks} Books To Read\n");
            lb.NumOfBooks = 1365;
            if (day == DayOfWeek.Monday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday || day == DayOfWeek.Sunday)
            {
                lb.Worker = "Jane";
            }
            else if (day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Saturday)
            {
                lb.Worker = "Marry";
            }
            Console.WriteLine($"Todays Librarian is {lb.Worker}");
        }
        static void Main(string[] args)
        {
            Library();
        }
    }
}
