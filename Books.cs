using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    public class Books
    {   // Declare blueprint for book
        public string? Title;
        public int Year;
        public int Pages;

        // Ovverride to a String
        public override string ToString()
        {   // Create a tool to read Year for each book.
            return string.Format("[{0}] {1} {2}", this.Title, this.Pages, this.Year);

        }


    }
}