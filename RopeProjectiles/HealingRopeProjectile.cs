using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using ReLogic.Content;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace RopeGuns.RopeProjectiles
{
    public class HealingRopeProjectile : ModProjectile
    {
		private static Asset<Texture2D> chainTexture;

		public override void Load()
		{ // This is called once on mod (re)load when this piece of content is being loaded.
		  // This is the path to the texture that we'll use for the hook's chain. Make sure to update it.
			chainTexture = ModContent.Request<Texture2D>("RopeGuns/RopeProjectiles/HealingRopeProjectile");
		}
		public override void Unload()
		{ // This is called once on mod reload when this piece of content is being unloaded.
		  // It's currently pretty important to unload your static fields like this, to avoid having parts of your mod remain in memory when it's been unloaded.
			chainTexture = null;
		}

		/*
		public override void SetStaticDefaults() {
			// If you wish for your hook projectile to have ONE copy of it PER player, uncomment this section.
			ProjectileID.Sets.SingleGrappleHook[Type] = true;
		}
		*/

		
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.GemHookRuby); // Copies the attributes of the Amethyst hook's projectile.
		}

		public override void NumGrappleHooks(Player player, ref int numHooks)
		{
			numHooks = 1; // The amount of hooks that can be shot out
		}

		// default is 11, Lunar is 24
		public override void GrappleRetreatSpeed(Player player, ref float speed)
		{
			speed = 11f; // How fast the grapple returns to you after meeting its max shoot distance
		}

		public override void GrapplePullSpeed(Player player, ref float speed)
		{
			speed = 10; // How fast you get pulled to the grappling hook projectile's landing position
		}

		// Draws the grappling hook's chain.
		public override bool PreDrawExtras()
		{
			Vector2 playerCenter = Main.player[Projectile.owner].MountedCenter;
			Vector2 center = Projectile.Center;
			Vector2 directionToPlayer = playerCenter - Projectile.Center;
			float chainRotation = directionToPlayer.ToRotation() - MathHelper.PiOver2;
			float distanceToPlayer = directionToPlayer.Length();

			while (distanceToPlayer > 20f && !float.IsNaN(distanceToPlayer))
			{
				directionToPlayer /= distanceToPlayer; // get unit vector
				directionToPlayer *= chainTexture.Height(); // multiply by chain link length

				center += directionToPlayer; // update draw position
				directionToPlayer = playerCenter - center; // update distance
				distanceToPlayer = directionToPlayer.Length();

				Color drawColor = Lighting.GetColor((int)center.X / 16, (int)(center.Y / 16));

				// Draw chain
				Main.EntitySpriteDraw(chainTexture.Value, center - Main.screenPosition,
					chainTexture.Value.Bounds, drawColor, chainRotation,
					chainTexture.Size() * 0.5f, 1f, SpriteEffects.None, 0);
			}
			// Stop vanilla from drawing the default chain.
			return false;
		}
	}
}

