using DesignPatterns.BehavioralDesignPattern.CORDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPattern.CORDesignPattern.CORimplementation
{
	internal class FiftyHandler : Handler
	{
		public override void DispatchNote(long requestedAmount)
		{
			//First Check the Number of 100 Notes To Be Dispatched
			long numberofNotesToBeDispatched = requestedAmount / 50;
			if (numberofNotesToBeDispatched > 0)
			{
				if (numberofNotesToBeDispatched > 1)
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by FiftyHandler");
				}
				else
				{
					Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by FiftyHandler");
				}
			}
			//No Need to Check the Next Handler
		}

	}
}
