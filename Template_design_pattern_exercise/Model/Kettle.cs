﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_design_pattern_exercise.Interfaces;

namespace Template_design_pattern_exercise.Model
{
	public class Kettle : IKettle
	{
		public void Boil()
		{
			
		}

		public void Pour(IBeverageContainer beverageContainer) { 
		
		}	
	}
}
