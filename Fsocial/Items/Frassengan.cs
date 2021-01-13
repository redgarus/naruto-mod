using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items
{
    public class Frassengan : ModItem
    {
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("FFF"); 
			Tooltip.SetDefault("Ради этих пуль ты убил монстра?.");
		}

		public override void SetDefaults() 
		{
            item.damage = 200; // значение урона
            item.ranged = true;                   
            item.width = 12;                   
            item.height = 12;
            item.maxStack = 999;              //сколько может содержаться в стаке 
            item.consumable = true;
			item.shoot = mod.ProjectileType("Frassenbul");         //какой Projectile будет использоваться
			item.shootSpeed = 5f; //скорость полета пули
            item.knockBack = 7;//откидывание при попадании 
            item.rare = 4;  //Редкость
            item.ammo = mod.ProjectileType("Frassenbul");
	    }
		
        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);   
            recipe.AddTile(TileID.WorkBenches);   
            recipe.SetResult(this);  
            recipe.AddRecipe();
        }
    }
} 