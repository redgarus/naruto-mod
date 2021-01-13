using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Projectile
{
    public class Frassenbul : ModProjectile
    {
		public override void SetStaticDefaults() {
            ProjectileID.Sets.TrailingMode[projectile.type] = 5;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 0;
        }
		
		public override void SetDefaults() {
            projectile.width = 32;                   
            projectile.height = 32;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;          // Дальний бой true - yes false - no
			projectile.penetrate = 5;
			projectile.timeLeft = 600;             
            projectile.light = 0.5f;       //Освщение при выстреле (наверное)
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;                
	    }
	}
}