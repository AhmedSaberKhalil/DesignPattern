using DesignPatterns.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodDesignPattern
{
	internal abstract class CreditCardFactory
	{
		protected abstract ICreditCard MakeProduct();
		public ICreditCard CreateProduct()
		{
			
			ICreditCard creditCard = this.MakeProduct();
		
			return creditCard;
		}
	}
}
