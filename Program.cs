using Microsoft.VisualBasic;
using Övningar;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;
// KWEJFIEJIJEFhuh
public class Program
{
    public static void Main(string[] args)
    {


        // Declare a List as Book
        var Books = new List<Books>();

        // Getting 3 books with title, pages and year from user

        Console.WriteLine("Vad heter boken?");
        string svar1 = Console.ReadLine();
        Console.WriteLine("Hur många sidor innehåller boken?");
        int svar2 = int.Parse(Console.ReadLine());
        Console.WriteLine("När släpptes boken??");
        int svar3 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Skriv in en bok till!");
        string svar4 = Console.ReadLine();
        Console.WriteLine("Hur många sidor innehåller boken?");
        int svar5 = int.Parse(Console.ReadLine());
        Console.WriteLine("När släpptes boken??");
        int svar6 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Skriv in den sista boken?");
        string svar7 = Console.ReadLine();
        Console.WriteLine("Hur många sidor innehåller boken?");
        int svar8 = int.Parse(Console.ReadLine());
        Console.WriteLine("När släpptes boken??");
        int svar9 = int.Parse(Console.ReadLine());
        Console.Clear();

        // List of answers from user
        Books.Add(new Books { Title = svar1, Pages = svar2, Year = svar3 });
        Books.Add(new Books { Title = svar4, Pages = svar5, Year = svar6 });
        Books.Add(new Books { Title = svar7, Pages = svar8, Year = svar9 });

        // To get Year in newest book first, compare and reverse.
        Books.Sort((b1, b2) => b1.Year.CompareTo(b2.Year));
        Books.Reverse();

        // Print the Data from List
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
        // Waiting for user to make a move
        Console.ReadKey();


















        //var books = new List<Books>();

        //books.Add(new Books { Title = "Harry Potter", Pages = 500, Year = 1997 });
        //books.Add(new Books { Title = "Lord of the rings", Pages = 600, Year = 1940 });
        //books.Add(new Books { Title = "Data", Pages = 504, Year = 2007 });
        //books.Add(new Books { Title = "Hästapparat", Pages = 534, Year = 2000 });
        //books.Add(new Books { Title = "Festboken", Pages = 524, Year = 2009 });

        //books.Sort((b1, b2) => b1.Year.CompareTo(b2.Year));

        //foreach (var book in books)
        //{
        //    Console.WriteLine(book);
        //}





    }
}