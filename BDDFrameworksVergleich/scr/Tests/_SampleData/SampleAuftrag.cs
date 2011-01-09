using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Model;

namespace Tests._SampleData
{
	public class SampleAuftrag
	{
		public static Auftrag Get()
		{
			return new Auftrag()
			       	{
			       		Id = 10,
			       		Käufer = new Käufer(),
			       		Verkäufer = new Verkäufer(),
			       		Positionen = new Positionen
			       		             	{
			       		             		new Position {Id = 1, Preis =  10.30m},
			       		             		new Position {Id = 2, Preis =  5.99m},
			       		             		new Position {Id = 3, Preis = 2},
			       		             	}
			       	};
		}
	}
}
