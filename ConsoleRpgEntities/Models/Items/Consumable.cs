﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgEntities.Models.Items
{
    public class Consumable : Item
    {
        public int Restore { get; set; }
    }
}
