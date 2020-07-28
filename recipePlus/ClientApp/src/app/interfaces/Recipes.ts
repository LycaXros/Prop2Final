import { Image } from "./Image";
import { Step } from "./Step";
import { Ingredient } from "./Ingredient";

export interface Recipes {
  recipeId: number;
  name: string;
  description: string;
  authorName: string;
  recipeImage: Image;
  steps: Step[];
  ingredients: Ingredient[];
  stepsCount: number;
  ingredientsCount: number;
}

