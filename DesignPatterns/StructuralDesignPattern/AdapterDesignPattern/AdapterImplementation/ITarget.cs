using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPattern.AdapterDesignPattern.AdapterImplementation
{
	internal interface ITarget
	{
		void ProcessCompanySalary(string[,] employeesArray);
	}
}
