﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.cs
{
    abstract class Person
    {
        private static int _id; 
        public int Id { get; set; }
        public string Name { get; set; }
        protected Person(string name)
        {
            Name = name;
            Id =_id++;
        }
    }
}
