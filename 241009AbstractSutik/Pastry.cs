using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241009AbstractSutik
{
	public abstract class Pastry
	{
		public string name;
		public decimal price;
		public int calories;

		public Pastry(string name, decimal price, int calories)
		{
			this.name = name;
			this.price = price;
			this.calories = calories;
		}
		public string Name { get => name; set => name = value; }
		public decimal Price { get => price; set => price = value;}
		public int Calories { get => calories; set => calories = value;}

		public void GetDescription()
		{

		}

		public void IncreasePrice(decimal increase)
		{

		}
		public override string ToString()
		{
			return $"{this.name}, {this.price} Ft, {this.calories} kcal";
		}
	}
}
