using Library.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class LibraryMember : Person
    {
public DateTime MemberShipDate {  get; set; }
        public LibraryMember(string name, DateTime membershipDate) : base(name)
        {
            MemberShipDate = membershipDate;
        }
    }
}
