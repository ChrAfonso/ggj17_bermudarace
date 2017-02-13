﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Players;

namespace Buffs
{
    sealed class TreasurePickupBuff : BuffBase
    {
        private readonly double modifier = 1.3;

        public override void InitBuff(Player player)
        {
            player.BuffMechanics.currentTreasurePickupSpeedModifier += modifier;
            base.InitBuff(player);
        }

        public override void BuffEnded(Player player)
        {
            player.BuffMechanics.currentTreasurePickupSpeedModifier -= modifier;
            base.BuffEnded(player);
        }
    }
}
