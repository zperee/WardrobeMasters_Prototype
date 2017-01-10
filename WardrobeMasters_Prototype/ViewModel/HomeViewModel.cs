using System;
using System.Collections.Generic;
using WardrobeMasters_Prototype.Model;

namespace WardrobeMasters_Prototype
{
	public class HomeViewModel
	{
		public List<Clothes> _clothes;

		public HomeViewModel()
		{
			_clothes = new List<Clothes>();
			_clothes.Add(new Clothes { Name = "Test" });
			_clothes.Add(new Clothes { Name = "Hello" });
		}

		public List<Clothes> Clothes
		{
			get { return _clothes; }

		}
	}
}
