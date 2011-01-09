using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
	public class Positionen : List<Position>
	{

		public decimal GetGesamtPreis()
		{
			return this.Sum(p => p.Preis);
		}

	}
}
