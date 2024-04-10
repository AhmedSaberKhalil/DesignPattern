using DesignPatterns.BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderDesignPattern.BuilderImplementation
{
	internal class ReportDirector
	{
		public Report MakeReport(ReportBuilder reportBuilder)
		{
			reportBuilder.CreateNewReport();
			reportBuilder.SetReportType();
			reportBuilder.SetReportHeader();
			reportBuilder.SetReportContent();
			reportBuilder.SetReportFooter();
			return reportBuilder.GetReport();
		}
	}
}
