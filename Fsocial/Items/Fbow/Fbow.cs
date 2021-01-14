//Created by KeysCG | Видеоуроки по моддингу террарии: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items.Fbow //название вашего мода
{
    public class Fbow : ModItem //название вашего скрипта
    {
    
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fbow"); //название объекта в игре
            Tooltip.SetDefault("Fbow shoot rassengans!"); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.damage = 500;
            item.crit = 100;
            item.noMelee = true;                   //Становится луком
            item.width = 22;                   
            item.height = 44;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
			item.shoot = mod.ProjectileType("Frassenbul");
			item.shootSpeed = 5;             //скорость полета стрелы 
			item.useAmmo = mod.ProjectileType("Frassenbul");         //то чем будет стрелять в нашем случае стрелой
            item.knockBack = 7;
            item.value = 90000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()  //Крафт
        {
            ModRecipe recipe = new ModRecipe(mod); //запуск рецепта
            recipe.AddIngredient(ItemID.Wood, 1);   //материал из которого будет крафтиться и количество
            recipe.AddIngredient(ItemID.StoneBlock, 1);   //материал из которого будет крафтиться и количество
            recipe.SetResult(this); //что мы получим в итоге 
            recipe.AddRecipe(); //завершение крафта
        }
    }
}