using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model.Beverage_containers
{
	public abstract class AbstractBeverageContainer : IBeverageContainer
	{
		internal List<IBeverageIngredient> ingredients = new List<IBeverageIngredient>();

		public void Brew()
		{

		}

		public abstract void Pour(ICup cup);

		public void AddIngredient(IBeverageIngredient ingredient) {
			ingredients.Add(ingredient);	
		}

	}
}
