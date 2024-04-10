using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPattern.FlyweightDesignPattern.Models
{
	internal interface ICreditCard
	{
		string GetCardType();
		int GetCreditLimit();
		int GetAnnualCharge();
	}
}
