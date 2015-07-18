using System;

namespace Cheers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			foreach (char l in name)
			{
				if ("aefhilmnosxAEFHILMNOSX".Contains(l))
				{
					Console.WriteLine("Give me an ...  {0}", l);
				}
				else Console.WriteLine("Give me a ..... {0}", l);
			}
			Console.WriteLine("{0} is ... GRAND", name);
			Console.ReadLine();

		}

	}
}