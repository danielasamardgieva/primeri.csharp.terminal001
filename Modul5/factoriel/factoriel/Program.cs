using System;

namespace factoriel
{
	class MainClass
	{
		public static int Fact(int _fact)
		{
			if (_fact <= 1)
				return 1;
			else
				return _fact * Fact (_fact - 1);
		}
		public static void Main (string[] args)
		{
			Console.WriteLine (Fact (3));
			Console.WriteLine (Fact (4));
			Console.WriteLine (Fact (5));
		}
	}
}
