﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Observer_Pattern_2
{
    public class Person
    {
        private readonly string _name;
        public string Name { get { return _name; } }
        public Person (string name)
        {
            _name = name;
        }

    }
}
