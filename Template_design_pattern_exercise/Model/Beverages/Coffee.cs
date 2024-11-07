using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model.Beverages
{
	internal class Coffee : AbstractBeverage
	{
		public Coffee(List<IBeverageIngredient> ingredients) : base(ingredients)
		{
			this.ingredients = ingredients;
		}
	}
}
