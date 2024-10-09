using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241009AbstractSutik
{
	internal class Bakery
	{
		private string name;
		private List<Pastry> Products;

		public Bakery( string name)
		{
			this.name = name;
		}

		public string Name { get => name; set => name = value; }

		public void AddProduct(Pastry newPastry)
		{
			Products.Add(newPastry);
		}

		public void displayProduct()
		{
			Console.WriteLine("Üzletünk termékei:");
			foreach (Pastry item in Products)
			{
				Console.WriteLine($"{item.name}......{item.price} Ft, {item.calories} kcal");
			}
		}
		public void CalculateCalories()
		{
			int total = 0;
			foreach (Pastry item in Products)
			{
				total += item.calories;
			}
            Console.WriteLine($"Összesen {total} kcal");

		}

		public void CalculatePrice()
		{
			decimal total = 0;
			foreach (Pastry item in Products)
			{
				total +=  item.price;
			}
            Console.WriteLine($"Összesen {total} Ft");
		}
		public override string ToString()
		{
			return $"Pékség neve: {this.name}";
		}
	}
}
