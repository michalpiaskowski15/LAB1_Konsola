﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_pia
{
    internal class Item
    {
        public int id;
        public int weight;
        public int value;

        public Item(int id, int weight, int value)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
        }
    }
}