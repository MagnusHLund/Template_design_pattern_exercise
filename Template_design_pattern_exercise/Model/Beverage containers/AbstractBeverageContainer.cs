using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model.Beverage_containers
{
	internal abstract class AbstractBeverageContainer : IBeverageContainer
	{
		public void Brew()
		{

		}

		public void Pour(ICup cup) { }

		public void AddIngredient(IBeverageIngredient ingredient) { }

	}
}
