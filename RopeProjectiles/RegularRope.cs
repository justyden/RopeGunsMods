﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RopeGuns.RopeProjectiles
{
    public class RegularRope : ModProjectile
    {
   
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Regular Rope");
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 1200;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = 1;
            Projectile.alpha = 255;
            //Projectile.usesLocalNPCImmunity = true;
            //Projectile.localNPCHitCooldown = -1;
            Projectile.usesIDStaticNPCImmunity = true;
            Projectile.idStaticNPCHitCooldown = 5;
            AIType = ProjectileID.Bullet;           
        }
        
        /*
        public override bool PreDraw(ref Color lightColor)
        {
            SpriteEffects spriteEffects = SpriteEffects.None;
            if (Projectile.spriteDirection == -1)
            {
                spriteEffects = SpriteEffects.FlipHorizontally;
            }
            Texture2D texture = (Texture2D)ModContent.Request<Texture2D>(Texture);
            int frameHeight = texture.Height;
            int startY = frameHeight * Projectile.frame;

            float changeY = 20f;
            Rectangle sourceRectangle = new Rectangle(0, startY, texture.Width, frameHeight);
            Vector2 orgin = sourceRectangle.Size() / 2f;
            orgin.Y = (float)(Projectile.spriteDirection == 1 ? sourceRectangle.Height - changeY : changeY);

            Color drawColor = Projectile.GetAlpha(lightColor);
            Main.EntitySpriteDraw(texture, Projectile.Center - Main.screenPosition
                + new Vector2(0f, Projectile.gfxOffY), sourceRectangle,
                drawColor, Projectile.rotation, orgin, Projectile.scale, spriteEffects, 0);
            return false;
        }
        */
    }
}
