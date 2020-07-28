using recipePlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipePlus.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FoodContext context)
        {
            //context.Database.EnsureCreated();
            if (context.Recipes.Any())
            {
                return;
            }

            var recipeArroz = new Recipe()
            {
                AuthorName = "Jesus DIcent",
                Name = "Arroz blanco a la mantequilla",
                Description = "Esta receta queda deliciosa y es perfecta para acompañar tus platillos favoritos, sobre todo nuestros deliciosos platos fuertes mexicanos como el picadillo, la tinga de pollo, un delicioso pollo al pastor, fajitas, enmoladas, pescado en salsa de mango y muchas más.",
            };

            context.Recipes.Add(recipeArroz);
            context.SaveChanges();
            var id = recipeArroz.RecipeId;
            var ing = new Ingredient[]
            {
                new Ingredient{ RecipeId = id, Descripcion =" 1 taza de arroz blanco crudo"},
                new Ingredient{ RecipeId = id, Descripcion ="1 trocito pequeño de cebolla blanca"},
                new Ingredient{ RecipeId = id, Descripcion ="1 diente de ajo chico pelado"},
                new Ingredient{ RecipeId = id, Descripcion ="Media taza de agua para licuar cebolla & ajo"},
                new Ingredient{ RecipeId = id, Descripcion ="2 tazas caldo de pollo de vegetales o agua (caliente)"},
                new Ingredient{ RecipeId = id, Descripcion ="2 cucharadas mantequilla"},
                new Ingredient{ RecipeId = id, Descripcion ="Una Cuarta parte de una taza zanahoria en cubos 1 zanahoria chica"},
                new Ingredient{ RecipeId = id, Descripcion ="Una cuarta parte de una taza chícharo congelado"},
                new Ingredient{ RecipeId = id, Descripcion ="una cuarta de taza elote cocido"},
                new Ingredient{ RecipeId = id, Descripcion ="Sal y pimienta al gusto"}
            };
            context.Ingredients.AddRange(ing);
            context.SaveChanges();

            var steps = new Step[]
            {
                new Step{StepNumber =1, RecipeId=id, Content= "Lava muy bien el arroz y seca en el colador."},
                new Step{StepNumber =2, RecipeId=id, Content= "Fríe el arroz a fuego medio alto en la mantequilla, esto asegura un arroz que no se bata después. Mueve constantemente cuanto estés haciendo esto. Antes de que se empiece a dorar agrega la mezcla de cebolla y ajo y sofríe un minuto más o hasta que casi se evapore el líquido."},
                new Step{StepNumber =3, RecipeId=id, Content= "Pasado el tiempo agrega el caldo caliente, sal y vegetales. Al primer hervor baja el fuego, tapa y cocina 15 minutos o hasta que se consuma el líquido por completo."},
                new Step{StepNumber =4, RecipeId=id, Content= "A los 15 minutos revisar que no tenga líquido, si ya está seco, apaga el fuego, tapa y deja reposar 10 a 15 minutos para que pueda seguirse cociendo con su calor."},
                new Step{StepNumber =5, RecipeId=id, Content= "Separa los granos con un tenedor."}
               
            };
            context.Steps.AddRange(steps);
            context.SaveChanges();
        }
    }
}
