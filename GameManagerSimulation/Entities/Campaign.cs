﻿using GameManagerSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSimulation.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
    }
}
