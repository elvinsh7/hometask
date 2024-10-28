using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class DVD : LibraryItem
    {
      
        
            public DVD(string title, int? publicationYear) : base(title, publicationYear)
        {
            Title = title;
            PublictionYear = publicationYear;
        }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Magazine Information: {Title},{PublicationYear}");
            }
        }
    }
}
