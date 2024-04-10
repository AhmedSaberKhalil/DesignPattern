using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPattern.StratgyDesignPattern.Models
{
	internal interface ICompression
	{
			void CompressFolder(string compressedArchiveFileName);
	}
}
