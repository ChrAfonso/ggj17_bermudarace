﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Players;


namespace Treasures
{
    public class Treasure
    {
        public string Name;
        public TreasureType Type = TreasureType.Speed;
        public Player LastOwner;
    }

    public enum TreasureType
    {
        Speed,
        PickupSpeed
    }
}
