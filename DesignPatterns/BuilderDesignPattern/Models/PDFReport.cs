using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderDesignPattern.BuilderImplementation
{
	internal class PDFReport : ReportBuilder
	{
		public override void SetReportContent()
		{
			reportObject.ReportContent = "PDF Content Section";
		}
		public override void SetReportFooter()
		{
			reportObject.ReportFooter = "PDF Footer";
		}
		public override void SetReportHeader()
		{
			reportObject.ReportHeader = "PDF Header";
		}
		public override void SetReportType()
		{
			reportObject.ReportType = "PDF";
		}
	}
}
