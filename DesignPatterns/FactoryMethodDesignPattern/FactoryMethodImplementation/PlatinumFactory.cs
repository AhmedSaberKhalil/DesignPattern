using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern
{
	internal class PlatinumFactory : CreditCardFactory
	{
		protected override ICreditCard MakeProduct()
		{
			ICreditCard creditCard = new Platinum();
			return creditCard;
		}
	}
}
