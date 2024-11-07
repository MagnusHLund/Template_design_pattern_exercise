using System;
using System.Collections.Generic;
using Template_design_pattern_exercise.Enums;
using Template_design_pattern_exercise.Model;
using Template_design_pattern_exercise.Model.Beverage_containers;
using Template_design_pattern_exercise.Model.Beverage_ingredients;

namespace Template_design_pattern_exercise.Factories
{
	internal class BeverageFactory
	{
		internal Cup MakeHotBeverage(BeverageEnum beverageToMake, List<AbstractExtraBeverageIngredient> extraIngredients)
		{
			Kettle kettle = new Kettle();
			kettle.Boil();

			AbstractBeverageContainer BeverageContainer = PrepareBeverage(beverageToMake);
			kettle.Pour(BeverageContainer);

			BeverageContainer.Brew();

			Cup cup = new Cup();
			BeverageContainer.Pour(cup);

			return AddExtraIngredients(cup, extraIngredients);
		}

		private AbstractBeverageContainer PrepareBeverage(BeverageEnum beverageToMake)
		{
			switch (beverageToMake)
			{
				case BeverageEnum.Tea:
					return PrepareTea();
				case BeverageEnum.Coffee:
					return PrepareCoffee();
				default:
					throw new NotImplementedException();
			}
		}

		private AbstractBeverageContainer PrepareCoffee()
		{
			PlungerJug plungerJug = new PlungerJug();
			CoffeeGrounds coffeeGrounds = new CoffeeGrounds();
			plungerJug.AddIngredient(coffeeGrounds);

			return plungerJug;
		}

		private AbstractBeverageContainer PrepareTea()
		{
			Teapot teapot = new Teapot();
			Teabag teabag = new Teabag();
			teapot.AddIngredient(teabag);

			return teapot;
		}

		private Cup AddExtraIngredients(Cup cup, List<AbstractExtraBeverageIngredient> extraIngredients)
		{
			foreach (AbstractExtraBeverageIngredient ingredientToAdd in extraIngredients)
			{
				cup.AddIngredient(ingredientToAdd);
			}

			return cup;
		}
	}
}
