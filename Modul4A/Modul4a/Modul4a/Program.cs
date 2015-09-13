using System;

namespace Modul4a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//definicia
			string _userinput = Console.Write ("?");

			//potrebitelski vhod
			do{
			_userinput = Console.ReadLine ();
		} while (_userinput !="exit");
	    }
		
	}
}