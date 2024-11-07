using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Enums;
using Template_design_pattern_exercise.Factories;
using Template_design_pattern_exercise.Interfaces;
using Template_design_pattern_exercise.Model;
using Template_design_pattern_exercise.Model.Beverage_ingredients;

namespace Template_design_pattern_exercise.Controller
{
	internal class MainController
	{
		internal void Main()
		{
			BeverageFactory beverageFactory = new BeverageFactory();

			Cup coffeeCup = MakeCoffee(beverageFactory);
			Cup teaCup = MakeTea(beverageFactory);

			coffeeCup.beverage.Drink();
			teaCup.beverage.Drink();
		}

		private Cup MakeCoffee(BeverageFactory beverageFactory)
		{
			List<AbstractExtraBeverageIngredient> extraIngredients = new List<AbstractExtraBeverageIngredient>
			{
				new Milk(),
				new Sugar()
			};

			return beverageFactory.MakeHotBeverage(BeverageEnum.Coffee, extraIngredients);
		}

		private Cup MakeTea(BeverageFactory beverageFactory)
		{
			List<AbstractExtraBeverageIngredient> extraIngredients = new List<AbstractExtraBeverageIngredient>
			{
				new Lemon(),
				new Sugar()
			};

			return beverageFactory.MakeHotBeverage(BeverageEnum.Coffee, extraIngredients);
		}
	}
}
