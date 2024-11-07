using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model.Beverages
{
	internal abstract class AbstractBeverage : IBeverage
	{
		internal List<IBeverageIngredient> ingredients;

		public AbstractBeverage(List<IBeverageIngredient> ingredients) {
			this.ingredients = ingredients;
		}

		public void Drink()
		{
			
		}
	}
}
