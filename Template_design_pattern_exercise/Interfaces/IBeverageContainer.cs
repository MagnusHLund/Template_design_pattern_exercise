using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_design_pattern_exercise.Interfaces
{
	public interface IBeverageContainer
	{
		void Brew();
		void Pour(ICup cup);
		void AddIngredient(IBeverageIngredient ingredient);
	}
}
