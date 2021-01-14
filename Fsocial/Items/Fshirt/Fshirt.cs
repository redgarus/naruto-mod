using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Fsocial.Items.Fshirt
{
    [AutoloadEquip(EquipType.Body)]
    public class Fshirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chunin Shirt");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 18;
            item.value = 12000;
            item.rare = 10;
            item.defense = 12;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("Fband");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.moveSpeed *= 1.5f;
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