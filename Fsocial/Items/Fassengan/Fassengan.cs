using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items
{
	public class Fassengan : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rassengan"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Rasseeeeengan!!!");
		}

		public override void SetDefaults() 
		{
			item.damage = 500;
			item.melee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true; //может ли персонаж обернуться во время работы
			item.crit = 100;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}