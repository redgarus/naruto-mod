//Created by KeysCG | Видеоуроки по моддингу террарии: "www.youtube.com/keysrec"
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fsocial.Items.Faxe //название вашего мода
{
    public class Faxe : ModItem //название вашего скрипта
    {
    
    public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("F axe"); //название объекта в игре
            Tooltip.SetDefault("F-social"); //описание объекта в игре
        }

        public override void SetDefaults() //свойства объекта
        {
            item.damage = 15; // значение урона
            item.melee = true; //тип оружия "melee" - ближнего боя в руках
            item.width = 32; //ширина спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.height = 32; //высота спрайта в пикселях (это значение для HitBox`a - невидимая граница для столкновений)
            item.useTime = 10; //???
            item.useAnimation = 20; //???
            item.axe = 300;    //сила топора
            item.useStyle = 1; //тип использования "1" - для размахивания
            item.knockBack = 10; //сила отбрасования "максимальное значение 20"
            item.value = 10000; //стоимость в медных монетах
            item.rare = 13; //редкость от -1 до 13
            item.UseSound = SoundID.Item1; //звук объекта
            item.autoReuse = true; //если зажата мышь то предмет работает непрерывно
            item.useTurn = true; //может ли персонаж обернуться во время работы
        }
        public override void AddRecipes()  //Крафт
        {
            ModRecipe recipe = new ModRecipe(mod); //запуск рецепта
            recipe.AddIngredient(ItemID.LunarBar, 10);   //материал из которого будет крафтиться и количество
            recipe.AddTile(TileID.TinkerersWorkbench);   //на чём будет крафтиться
            recipe.SetResult(this); //что мы получим в итоге 
            recipe.AddRecipe(); //завершение крафта
        }
    }
}