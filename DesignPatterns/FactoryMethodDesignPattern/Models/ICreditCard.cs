using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern
{
	internal interface ICreditCard
	{
		string GetCardType();
		int GetCreditLimit();
		int GetAnnualCharge();
	}
}
