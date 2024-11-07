using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model
{
	internal class Cup : ICup
	{
		public IBeverage beverage { get; set; }

		public void AddIngredient(IBeverageIngredient extraIngredient)
		{

		}
	}
}
