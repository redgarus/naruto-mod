using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items
{
    public class Frassengan : ModItem
    {
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("FFF"); 
			Tooltip.SetDefault("���� ���� ���� �� ���� �������?.");
		}

		public override void SetDefaults() 
		{
            item.damage = 200; // �������� �����
            item.ranged = true;                   
            item.width = 12;                   
            item.height = 12;
            item.maxStack = 999;              //������� ����� ����������� � ����� 
            item.consumable = true;
			item.shoot = mod.ProjectileType("Frassenbul");         //����� Projectile ����� ��������������
			item.shootSpeed = 5f; //�������� ������ ����
            item.knockBack = 7;//����������� ��� ��������� 
            item.rare = 4;  //��������
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