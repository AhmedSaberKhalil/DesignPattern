using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPattern.CORDesignPattern.Models
{
	internal abstract class Handler
	{
		//The NextHandler will hold the reference of the next handler
		public Handler NextHandler;
		//Initializing NextHandler reference using the class constructor
		public void SetNextHandler(Handler NextHandler)
		{
			this.NextHandler = NextHandler;
		}
		
		public abstract void DispatchNote(long requestedAmount);
	}
}
