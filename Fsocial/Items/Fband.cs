using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items
{
    [AutoloadEquip(EquipType.Head)]
	public class Fband : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chunin Headband");
			Tooltip.SetDefault("Ghg");
        }
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
            item.defense = 10;
		}

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 1.2f;

        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawAltHair = true;
            drawHair=false;
        }

        public override void   AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 15);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
