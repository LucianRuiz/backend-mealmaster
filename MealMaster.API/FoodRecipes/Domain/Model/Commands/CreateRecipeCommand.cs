﻿using BasePlatform.API.FoodRecipes.Domain.Model.ValueObjects;

namespace BasePlatform.API.FoodRecipes.Domain.Model.Commands;

public record CreateRecipeCommand(string name, List<string> ingredients /*Cambiar string por clase Ingredients*/ , string directions, string imageUrl, int calories, int proteins, int fats, int carbohydrates, EDifficultyTag difficulty, EMealtTimeTag mealTime, EPrincingTag princing, ETypeCuisine typeCuisine);