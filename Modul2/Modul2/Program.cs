using System;

namespace Modul2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a=0, b=0, c=0;
		
			//Събиране на числа
			a=5;
			b = 10;
			Console.Write (" a = ");
			Console.Write (a);
			Console.Write (" b = ");
			Console.Write (b);

			//Смяна на стойностите
			c=a;
			a = b;
			b=c;

			Console.Write (" Смяна на стойностите -> a = ");
			Console.Write (a);
			Console.Write (" b = ");
			Console.Write (b);
		

		}
	}
}
