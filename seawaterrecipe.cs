
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace ChromasMod
{
    public class seawaterrecipe : ModRecipe
    {
        public seawaterrecipe(Mod mod) : base(mod)
        { }

        public override bool RecipeAvailable()
        {
            if (Main.LocalPlayer.ZoneBeach)
            {
                return true;
            }
            return false;
        }
    }

    //Here's the item where we will add our recipe
    public class seawater : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Water");
            Tooltip.SetDefault("Salty and gritty.. Dont even think about drinking it.");
        }

        public override string Texture => "ChromasMod/Items/seawater";

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.rare = 1;
            item.maxStack = 999;

        }

        //Using our custom recipe type
        public override void AddRecipes()
        {
            seawaterrecipe recipe = new seawaterrecipe(mod);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.needWater = true;
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
