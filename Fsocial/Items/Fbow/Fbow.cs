//Created by KeysCG | ���������� �� �������� ��������: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items.Fbow //�������� ������ ����
{
    public class Fbow : ModItem //�������� ������ �������
    {
    
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fbow"); //�������� ������� � ����
            Tooltip.SetDefault("Fbow shoot rassengans!"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.damage = 500;
            item.crit = 100;
            item.noMelee = true;                   //���������� �����
            item.width = 22;                   
            item.height = 44;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
			item.shoot = mod.ProjectileType("Frassenbul");
			item.shootSpeed = 5;             //�������� ������ ������ 
			item.useAmmo = mod.ProjectileType("Frassenbul");         //�� ��� ����� �������� � ����� ������ �������
            item.knockBack = 7;
            item.value = 90000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()  //�����
        {
            ModRecipe recipe = new ModRecipe(mod); //������ �������
            recipe.AddIngredient(ItemID.Wood, 1);   //�������� �� �������� ����� ���������� � ����������
            recipe.AddIngredient(ItemID.StoneBlock, 1);   //�������� �� �������� ����� ���������� � ����������
            recipe.SetResult(this); //��� �� ������� � ����� 
            recipe.AddRecipe(); //���������� ������
        }
    }
}