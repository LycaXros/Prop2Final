namespace recipePlus.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Descripcion { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
    public class IngredientViewModel
    {
        public int IngredientId { get; set; }
        public string Descripcion { get; set; }
        public int RecipeId { get; set; }

    }
}
