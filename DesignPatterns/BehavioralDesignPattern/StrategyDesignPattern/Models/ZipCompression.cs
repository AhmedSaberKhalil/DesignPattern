using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralDesignPattern.StratgyDesignPattern.Models
{
	internal class ZipCompression : ICompression
	{
		public void CompressFolder(string compressedArchiveFileName)
		{
			Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
				 + ".zip' file is created");
		}
	}
}
