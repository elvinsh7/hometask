using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    static class LibraryHelper
    {
        public int Calculagate(this LibraryItem item)
        {
            int now = DateTime.Now.Year;
            int result = (int)(now - item.PublictionYear);
            return result;
        }
        public static string ToTitleCase(this LibraryItem item)
        {
            return Char.ToUpper(item.Title[0]) + item.Title.Substring(1).ToLower() ;
        }
    }
}
