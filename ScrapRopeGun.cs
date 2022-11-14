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
            // Gives the weapon a name as well as a tooltip.
            DisplayName.SetDefault("Scrap Rope Gun");
            Tooltip.SetDefault("A rope shooter that appears to just hardly be operational.");
        }

        public override void SetDefaults()
        {
            // The way the weapon scales while it is being held.
            Item.width = 40;
            Item.height = 30;

            // Weapon stats
            Item.value = 100;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 1;
            Item.knockBack = 1;
            Item.noMelee = true;

            //Weapon fire properties
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.shoot = ModContent.ProjectileType<RegularRope>();
            Item.useAmmo = ItemID.Rope;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.shootSpeed = 10;

        }


        public override Vector2? HoldoutOffset()
        {
            // Lets the location of the weapon be in the correct spot on the player model.
            return new Vector2(2f, -2f);
        }

        public override void AddRecipes()
        {
            // Creates a recipe
            CreateRecipe().AddIngredient(ItemID.StoneBlock, 1);
            CreateRecipe().AddTile(TileID.WorkBenches);
            CreateRecipe().Register();
        }
    }
}
