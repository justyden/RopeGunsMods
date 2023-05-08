using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using ReLogic.Content;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using RopeGuns.RopeProjectiles;

namespace RopeGuns.RopeWeapons
{
    public class HealingRopeGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Gives the weapon a name as well as a tooltip.
            DisplayName.SetDefault("Healing Rope Gun");
            Tooltip.SetDefault("A rope shooter with a heart attached to the end of it." +
                " Heals depending on distance traveled.");
        }

        public override void SetDefaults()
        {
            // The way the weapon scales while it is being held.
            Item.CloneDefaults(ItemID.Hook);
            Item.width = 40;
            Item.height = 30;

            // Weapon stats
            Item.value = 100;
            Item.rare = ItemRarityID.Green;
            //Item.useTime = 30;
            Item.useAnimation = 10;
            Item.autoReuse = false;
            Item.noMelee = true;

            //Weapon fire properties
            Item.shoot = ModContent.ProjectileType<HealingRopeProjectile>();
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.shootSpeed = 10;

        }

        public override Vector2? HoldoutOffset()
        {
            // Lets the location of the weapon be in the correct spot on the player model.
            return new Vector2(-16f, 4f);
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
