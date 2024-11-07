using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;
using Template_design_pattern_exercise.Model.Beverages;

namespace Template_design_pattern_exercise.Model.Beverage_containers
{
	internal class Teapot : AbstractBeverageContainer
	{
		public override void Pour(ICup cup)
		{
			cup.beverage = new Tea(ingredients);
		}
	}
}
