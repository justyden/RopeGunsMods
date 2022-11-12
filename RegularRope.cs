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
            Main.projFrames[Projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            Projectile.width = 10;
            Projectile.height = 5;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 1200;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = 1;
            Projectile.alpha = 255;
            AIType = ProjectileID.WaterStream;

        }
    }
}
