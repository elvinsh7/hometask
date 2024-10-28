using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.cs
{
    internal class Magazine : LibraryItem
    {
        public Magazine(string title, int? publictionYear): base(title, publictionYear)
        {
            Title = title;
            PublictionYear = publictionYear;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine Information:{Title},{PublictionYear}");
        }
        
    }
    

 }


