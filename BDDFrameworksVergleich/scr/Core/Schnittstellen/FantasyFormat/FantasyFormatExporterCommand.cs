using Core.Model;

namespace Core.Schnittstellen
{
	public class FantasyFormatExporterCommand
	{
		public Auftrag Auftrag;
		public string OutputPath = "out.xml";
	}
}