using AutoMapper;
using recipePlus.Controllers;
using recipePlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipePlus.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Image, ImageViewModel>();
            CreateMap<Step, StepViewModel>();
            CreateMap<Ingredient, IngredientViewModel>();
            CreateMap<Recipe, RecipeViewModel>();
        }
    }
}
