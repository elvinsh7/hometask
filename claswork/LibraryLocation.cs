using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class LibraryLocation
    {
        public struct LibraryLocation
        {
            public int Aisle { get; set;}
            public int Shelf { get; set;}

            public LibraryLocation(int aisle, int shelf)
            {
                Aisle = aisle;
                Shelf = shelf;
                
            }

            public override bool Equals(object? obj)
            {
                return obj is LibraryLocation location &&
                       Aisle == location.Aisle &&
                       Shelf == location.Shelf;
            }
        }
    }
}
