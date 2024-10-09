using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241009AbstractSutik
{
	internal class Bagel
	{
		private string nev;
		private double price;
		private int calories;

		protected Bagel(string nev, double price, int calories)
		{
			this.nev = nev;
			this.price = price;
			this.calories = calories;
		}

		public abstract GetDescription();
		public abstract void IncreasePrice(double amount);
	}
}
