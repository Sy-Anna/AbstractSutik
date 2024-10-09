using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241009AbstractSutik
{
	internal class Croissant:Pastry
	{
		private int butter;

		public Croissant(int butter) : base(name, price, calories)
		{
			this.butter = butter;
		}
		public override string ToString()
		{
			return base.ToString() + $"{butter}";
		}
	}
}
