using Library.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class LibraryItem
    {
        public LibraryLocation Location;
        public string Title { get; set; }
        public int?  PublictionYear { get; set; }
    protected LibraryItem(string title, int? publicationYear)
        {
            Title = title;
            PublictionYear = publicationYear;
        }
        public abstract void DisplayInfo();
    }
}
