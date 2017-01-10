using System;
using System.Collections.Generic;

namespace WardrobeMasters_Prototype.Model
{
	public class Clothes : Base
	{
		public string Size { get; set; }
		public string Color { get; set; }
		public Brand Brand { get; set; }
		public Type Type { get; set; }
	}
}
