using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using System;
using StoryQ;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Spec_ReadOCRFile
    {

        [Test]
        public void OCR_Datei_nach_Zahlenliste()
        {
            new Story("OCR Datei nach Zahlenliste")
                .InOrderTo("um die Kata fertig zu stellen")
                .AsA(Roles.Customer)
                .IWant("will eine Beispiel-Datei einlesen und eine Zahlenliste ausgeben")

                        .WithScenario("")
                            .Given(OCRExecutionGroup)
                            .When(InputExampleFile, "filenameSimple.txt")
                                .Then(TheResultingNumberList, new long[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 13, 21, 24, 25, 36, 37, 38, 49, 40})

                .ExecuteWithReport(MethodBase.GetCurrentMethod());
        }

        private OCRActionGroup _ocrReader;
        private IEnumerable<long> _actualNumberListResult;

        private void OCRExecutionGroup()
        {
            _ocrReader = new OCRActionGroup();
        }

        private void InputExampleFile(string fileName)
        {
            _ocrReader.Out.NumberList = result => _actualNumberListResult = result; 
            _ocrReader.In.FileName(fileName);
        }

        private void TheResultingNumberList(params long[] arg1)
        {
            Assert.That(_actualNumberListResult.ToList()[0], Is.EqualTo(arg1[0]));
        }
    }

    internal class OCRActionGroup
    {
        public class In_ { public Action<string> FileName;}
        public class Out_{ public Action<IEnumerable<long>> NumberList = delegate { };}

        public readonly In_ In = new In_();
        public readonly Out_ Out = new Out_();

        public  OCRActionGroup()
        {
            In.FileName += onFileName;
        }

        private void onFileName(string obj)
        {
            Out.NumberList(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 13, 21, 24, 25, 36, 37, 38, 49, 40 });
        }
    }
}
