﻿using DesignPatterns.BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderDesignPattern.BuilderImplementation
{
	internal abstract class ReportBuilder
	{
		protected Report reportObject;
		public abstract void SetReportType();
		public abstract void SetReportHeader();
		public abstract void SetReportContent();
		public abstract void SetReportFooter();
		public void CreateNewReport()
		{
			reportObject = new Report();
		}
		public Report GetReport()
		{
			return reportObject;
		}
	}
}
