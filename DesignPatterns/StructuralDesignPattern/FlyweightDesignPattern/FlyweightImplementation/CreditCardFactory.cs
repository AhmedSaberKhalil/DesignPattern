using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPattern.FlyweightDesignPattern.Models
{
	internal class CreditCardFactory
	{
		public static ICreditCard GetCreditCard(string cardType)
		{
			Dictionary<string, ICreditCard> calc = new Dictionary<string, ICreditCard>();

			ICreditCard cardDetails = null;
			if(calc.ContainsKey(cardType))
			{
				return calc[cardType];
			}
			else
			{
				switch(cardType)
				{
					case "MoneyBack":
						var calculator = new MoneyBack();
						calc.Add("MoneyBack", calculator);
						break;
					case "Titanium":
						 calculator = new MoneyBack();
						calc.Add("Titanium", calculator);
						break;
				}
				return cardDetails;

			}

		}
	}
}
