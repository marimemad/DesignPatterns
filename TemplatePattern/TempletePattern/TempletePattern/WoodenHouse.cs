﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempletePattern
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods, wood and sand");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood Pillars with wood coating");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building Wood Walls");
        }

        protected override void BuildWindwo()
        {
            Console.WriteLine("Building Wood Windows");
        }
    }
}
