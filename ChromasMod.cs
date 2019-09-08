using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ChromasMod
{
    public class ChromasMod : Mod
    {
        public ChromasMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void AddRecipes()
        {
            {
                ModRecipe recipe = new ModRecipe(this);
                recipe.AddIngredient(ItemID.RottenChunk, 2);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(ItemID.Leather);
                recipe.AddRecipe();
            }
            { 
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "glassfrit", 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(ItemID.Glass);
            recipe.AddRecipe();
            }
            {
                ModRecipe recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "seawater");
                recipe.AddTile(TileID.Furnaces);
                recipe.SetResult(null, "assortedcrystals");
                recipe.AddRecipe();
            }
        }
    }
}
