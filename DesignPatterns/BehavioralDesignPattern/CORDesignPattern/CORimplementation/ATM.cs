using DesignPatterns.BehavioralDesignPattern.CORDesignPattern.CORimplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPattern.CORDesignPattern
{
	internal class ATM
	{
		private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
		private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
		private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
		private HundredHandler hundredHandler = new HundredHandler();
		private FiftyHandler fiftyHandler = new FiftyHandler();
		public ATM()
		{
			// Prepare the chain of Handlers
			// Here, we need to set the next handler of each handler
			twoThousandHandler.SetNextHandler(fiveHundredHandler);
			fiveHundredHandler.SetNextHandler(twoHundredHandler);
			twoHundredHandler.SetNextHandler(hundredHandler);
			hundredHandler.SetNextHandler(fiftyHandler);
		}
		//The following method handle the request and passes it to the first handler in the chain of responsibility.
		public void Withdraw(long requestedAmount)
		{
			//First check whether the amount is Divisible by 100 or not
			if (requestedAmount % 50 == 0)
			{
				twoThousandHandler.DispatchNote(requestedAmount);
			}
			else
			{
				Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
			}
		}
	}
}
