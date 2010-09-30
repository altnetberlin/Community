using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
	public class Auftrag
	{
		public int Id;
		
		public Käufer Käufer;
		public Verkäufer Verkäufer;

		public Positionen Positionen ;

		public decimal Gesamtpreis { get { return Positionen.GetGesamtPreis(); } }

	}
}
