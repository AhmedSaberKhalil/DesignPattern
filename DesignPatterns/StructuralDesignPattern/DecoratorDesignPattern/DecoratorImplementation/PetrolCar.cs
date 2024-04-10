using DesignPatterns.StructuralDesignPattern.DecoratorDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDesignPattern.DecoratorDesignPattern.DecoratorImplementation
{
	internal class PetrolCar : ICar
	{
		private readonly ICar _car;

		public PetrolCar(ICar car)
        {
			this._car = car;
		}

		public ICar ManufactureCar()
		{
		    _car.ManufactureCar();
			AddEngine(_car);
			return _car;

		}
		public void AddEngine(ICar car)
		{
			if (car is BMWCar BMWCar)
			{
				BMWCar.Engine = "Petrol Engine";
				Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
			}
		}
	}
}
