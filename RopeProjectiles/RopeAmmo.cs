using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace RopeGuns.RopeProjectiles
{
    public class RopeAmmo : GlobalItem
    {
        
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Rope)
            {
                item.ammo = ItemID.Rope;
                item.shoot = ModContent.ProjectileType<RegularRope>();
                item.damage = 1;
            }
        }
    }
}
