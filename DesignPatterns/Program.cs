using DesignPatterns.BehavioralDesignPattern.CORDesignPattern;
using DesignPatterns.BehavioralDesignPattern.StratgyDesignPattern.Models;
using DesignPatterns.BehavioralDesignPattern.StratgyDesignPattern.StratgyImplementation;
using DesignPatterns.BuilderDesignPattern.BuilderImplementation;
using DesignPatterns.BuilderDesignPattern.Models;
using DesignPatterns.FactoryDesignPattern;
using DesignPatterns.FactoryMethodDesignPattern;
using DesignPatterns.PrototypeDesignPattern.Models;
using DesignPatterns.StructuralDesignPattern.AdapterDesignPattern.AdapterImplementation;
using DesignPatterns.StructuralDesignPattern.DecoratorDesignPattern.DecoratorImplementation;
using DesignPatterns.StructuralDesignPattern.DecoratorDesignPattern.Models;
using DesignPatterns.StructuralDesignPattern.FacadeDesignPattern.FacadeImplementation;
using DesignPatterns.StructuralDesignPattern.ProxyDesignPattern.ProxyImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region Factory Design Pattern 
			//         FactoryDesignPattern.ICreditCard cardDetails = FactoryDesignPattern.CreditCardFactory.GetCreditCard("Platinum");

			//if (cardDetails != null)
			//{
			//	Console.WriteLine("CardType : " + cardDetails.GetCardType());
			//	Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
			//	Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
			//}
			//else
			//{
			//	Console.Write("Invalid Card Type");
			//}
			//Console.ReadLine();
			#endregion

			#region Factory Method Design Pattern 
			//FactoryMethodDesignPattern.ICreditCard creditCard = new PlatinumFactory().CreateProduct();
			//if (creditCard != null)
			//{
			//	Console.WriteLine("Card Type : " + creditCard.GetCardType());
			//	Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
			//	Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
			//}
			//else
			//{
			//	Console.Write("Invalid Card Type");
			//}
			//Console.WriteLine("--------------");
			////MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
			//creditCard = new MoneyBackFactory().CreateProduct();
			//if (creditCard != null)
			//{
			//	Console.WriteLine("Card Type : " + creditCard.GetCardType());
			//	Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
			//	Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
			//}
			//else
			//{
			//	Console.Write("Invalid Card Type");
			//}
			//Console.ReadLine(); 
			#endregion

			#region Builder Design Pattern 
			//PDFReport pdfReport = new PDFReport();

			//ReportDirector reportDirector = new ReportDirector();

			//Report report = reportDirector.MakeReport(pdfReport);

			//report.DisplayReport();
			//Console.WriteLine("-------------------");

			//ExcelReport excelReport = new ExcelReport();
			//report = reportDirector.MakeReport(excelReport);
			//report.DisplayReport();
			//Console.ReadKey(); 
			#endregion

			#region Prototype Design Pattern 
			//Employee emp1 = new PermanentEmployee()
			//{
			//	Name = "Anurag",
			//	Department = "IT",
			//	Type = "Permanent",
			//	Salary = 100000
			//};
			//Employee emp2 = emp1.GetClone();

			//emp2.Name = "Pranaya";
			//emp2.Department = "HR";
			//emp1.ShowDetails();
			//emp2.ShowDetails();

			//Employee emp3 = new TemporaryEmployee()
			//{
			//	Name = "Preety",
			//	Department = "HR",
			//	Type = "Temporary",
			//	FixedAmount = 200000
			//};

			//Employee emp4 = emp3.GetClone();

			//emp4.Name = "Priyanka";
			//emp4.Department = "Sales";
			//emp3.ShowDetails();
			//emp4.ShowDetails();

			//Console.Read(); 
			#endregion

			#region Adapter Design Pattern  
			//string[,] employeesArray = new string[5, 4]
			// {
			//	{"101","John","SE","10000"},
			//	{"102","Smith","SE","20000"},
			//	{"103","Dev","SSE","30000"},
			//	{"104","Pam","SE","40000"},
			//	{"105","Sara","SSE","50000"}
			// };

			//Console.WriteLine("HR system passes employee string array to Adapter\n");
			//ITarget target = new EmployeeAdapter();
			//target.ProcessCompanySalary(employeesArray);
			//Console.Read(); 
			#endregion

			#region Facade Design Pattern 
			//Order order = new Order();
			//order.PlaceOrder();
			//Console.Read(); 
			#endregion

			#region Decorator Design Pattern 
			//ICar bmwCar1 = new BMWCar();
			//bmwCar1.ManufactureCar();
			//Console.WriteLine(bmwCar1 + "\n");

			//ICar bmwCar2 = new BMWCar();
			//PetrolCar carWithPetrolEngine = new PetrolCar(bmwCar2);
			//carWithPetrolEngine.ManufactureCar();
			//Console.ReadKey(); 
			#endregion

			#region Flyweight Design Pattern 
			//FactoryDesignPattern.ICreditCard cardDetails = FactoryDesignPattern.CreditCardFactory.GetCreditCard("Titanium");

			//if (cardDetails != null)
			//{
			//	Console.WriteLine("CardType : " + cardDetails.GetCardType());
			//	Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
			//	Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
			//}
			//else
			//{
			//	Console.Write("Invalid Card Type");
			//}
			//Console.ReadLine();
			#endregion

			#region Proxy Design Pattern 
			//Console.WriteLine("Client passing employee with Role Developer to folderproxy");
			//StructuralDesignPattern.ProxyDesignPattern.Models.Employee emp1 = 
			//	new StructuralDesignPattern.ProxyDesignPattern.Models.Employee("Anurag", "Anurag123", "Developer");
			//SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
			//folderProxy1.PerformRWOperations();
			//Console.WriteLine();
			//Console.WriteLine("Client passing employee with Role Manager to folderproxy");
			//StructuralDesignPattern.ProxyDesignPattern.Models.Employee emp2 = 
			//	new StructuralDesignPattern.ProxyDesignPattern.Models.Employee("Pranaya", "Pranaya123", "Manager");
			//SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
			//folderProxy2.PerformRWOperations();
			//Console.Read(); 
			#endregion

			#region StrategyDesignPattern 
			//ICompression strategy = new ZipCompression();
			//CompressionContext ctx = new CompressionContext(strategy);
			//ctx.CreateArchive("DotNetDesignPattern");
			//ctx.SetStrategy(new RarCompression());
			//ctx.CreateArchive("DotNetDesignPattern");
			//Console.Read();
			#endregion

			#region COR Design Pattern  
			//ATM atm = new ATM();
			//Console.WriteLine("Requested Amount 4600");
			//atm.Withdraw(4600);
			//Console.WriteLine("\nRequested Amount 1900");
			//atm.Withdraw(1900);
			//Console.WriteLine("\nRequested Amount 600");
			//atm.Withdraw(600);
			//Console.WriteLine("\nRequested Amount 750");
			//atm.Withdraw(750);
			//Console.Read(); 
			#endregion


		}
	}
}
