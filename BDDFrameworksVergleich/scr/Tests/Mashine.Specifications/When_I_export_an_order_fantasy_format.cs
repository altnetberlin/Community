using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Core.Model;
using Core.Schnittstellen;
using Machine.Specifications;
using Tests.SampleData;

namespace Tests.Mashine.Specifications
{
	public class ExportSpec
	{
		protected static Auftrag _sampleAuftrag;
		protected static FantasyFormatExporter _fantasyFormatExporter;

		protected Establish context = () =>
		                            	{
		                            		_sampleAuftrag = SampleAuftrag.Get();
		                            		_fantasyFormatExporter = new FantasyFormatExporter();
		                            	};
	}

	[Subject("Data export")]
	public class When_I_export_an_order_fantasy_format : ExportSpec
	{
		private Because of = () => _fantasyFormatExporter.Run(_sampleAuftrag, "demo.xml");

		It should_exist_a_file_demo_xml = () => File.Exists("demo.xml").ShouldBeTrue();

		It should_have_a_node_KäuferName = () => new XDocument("demo.xml").Root
		                                                 	.Element("Käufer")
															.Element("Name").Value.ShouldEqual(_sampleAuftrag.Käufer.Name);
	}


}
