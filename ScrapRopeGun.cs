using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace RopeGuns
{
    public class ScrapRopeGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scrap Rope Gun");
            Tooltip.SetDefault("A rope shooter that appears to just hardly be operational.");
        }

        public override void SetDefaults()
        {
            // The way the weapon scales while it is being held.
            Item.width = 20;
            Item.height = 20;

            // Weapon stats
            Item.value = 100;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 1;
            Item.knockBack = 1;
            Item.noMelee = true;

            //Weapon fire properties
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.shoot = ModContent.ProjectileType<RegularRope>();
            Item.useAmmo = ItemID.Rope;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.shootSpeed = 16f;

        }


        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }

        


    }
}
