using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class Book : LibraryItem
    {
        
        public BookJenre Genre { get; set; }


        public Book(string title, int? publicationYear) : base(title, publicationYear)
        {
            Title = title;
            PublictionYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Information: {Title},{PublictionYear}");
        }
    }
    struct LibraryLocation
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }

    }
}