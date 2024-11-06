using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Enums;
using Template_design_pattern_exercise.Factories;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Controller
{
	internal class MainController
	{
		internal void Main()
		{
			BeverageFactory beverageFactory = new BeverageFactory();
			ICup tea = beverageFactory.MakeHotBeverage(BeverageEnum.Tea);
			ICup coffee = beverageFactory.MakeHotBeverage(BeverageEnum.Coffee);

			tea.
		}
	}
}
