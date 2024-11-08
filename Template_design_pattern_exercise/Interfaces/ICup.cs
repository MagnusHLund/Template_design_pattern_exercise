﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_design_pattern_exercise.Interfaces
{
	public interface ICup
	{
		IBeverage beverage { get; set;  }

		void AddIngredient(IBeverageIngredient extraIngredient);
	}
}
