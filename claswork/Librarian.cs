using Library.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class Librarian: Person
    { 
    public DateTime  HireDate { get; set; }
        public Librarian(string name) : base(name)
        {
            Name = name;
        }
    }
}
