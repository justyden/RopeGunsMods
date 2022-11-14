using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RopeGuns
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
            Projectile.width = 40;
            Projectile.height = 40;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 1200;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = 1;
            Projectile.alpha = 255;
            AIType = ProjectileID.Bullet;

        }
    }
}
