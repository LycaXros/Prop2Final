using System.Collections.Generic;
using System.Linq;

namespace recipePlus.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Steps = new HashSet<Step>();
            Ingredients = new HashSet<Ingredient>();
        }
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public Image RecipeImage { get; set; }
        public virtual ICollection<Step> Steps { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public ImageViewModel RecipeImage { get; set; }
        public List<StepViewModel> Steps { get; set; }
        public List<IngredientViewModel> Ingredients { get; set; }

        public int StepsCount => Steps.Count();
        public int IngredientsCount => Ingredients.Count();
    }
}
