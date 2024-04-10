using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern
{
	internal class MoneyBackFactory : CreditCardFactory
	{
		protected override ICreditCard MakeProduct()
		{
			ICreditCard creditCard = new MoneyBack();
			return creditCard;
		}
	}
}
