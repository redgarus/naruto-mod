//Created by KeysCG | ���������� �� �������� ��������: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items.Faxe //�������� ������ ����
{
    public class Faxe : ModItem //�������� ������ �������
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("F axe"); //�������� ������� � ����
            Tooltip.SetDefault("F-social"); //�������� ������� � ����
        }

        public override void SetDefaults() //�������� �������
        {
            item.damage = 15; // �������� �����
            item.melee = true; //��� ������ "melee" - �������� ��� � �����
            item.width = 32; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.height = 32; //������ ������� � �������� (��� �������� ��� HitBox`a - ��������� ������� ��� ������������)
            item.useTime = 10; //???
            item.useAnimation = 20; //???
            item.axe = 300;    //���� ������
            item.useStyle = 1; //��� ������������� "1" - ��� ������������
            item.knockBack = 10; //���� ������������ "������������ �������� 20"
            item.value = 10000; //��������� � ������ �������
            item.rare = 13; //�������� �� -1 �� 13
            item.UseSound = SoundID.Item1; //���� �������
            item.autoReuse = true; //���� ������ ���� �� ������� �������� ����������
            item.useTurn = true; //����� �� �������� ���������� �� ����� ������
        }
        public override void AddRecipes()  //�����
        {
            ModRecipe recipe = new ModRecipe(mod); //������ �������
            recipe.AddIngredient(ItemID.LunarBar, 10);   //�������� �� �������� ����� ���������� � ����������
            recipe.AddTile(TileID.TinkerersWorkbench);   //�� ��� ����� ����������
            recipe.SetResult(this); //��� �� ������� � ����� 
            recipe.AddRecipe(); //���������� ������
        }
    }
}