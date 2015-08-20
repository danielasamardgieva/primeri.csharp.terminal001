using System;

namespace Modul2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
		
			//Събиране на числа
			a = 10;
			b = 5;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.WriteLine ("/n Резултат а+в=");
			a += b;
			Console.WriteLine (a);

			//Изваждане на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.WriteLine ("/n Резултат а-в=");
			a -= b;
			Console.WriteLine (a);
		
			//Умножение на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.WriteLine ("/n Резултат а*в=");
			a *= b;
			Console.WriteLine (a);

			//Стандартно=Целочислено деление на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.WriteLine ("/n Резултат а/в=");
			Console.WriteLine (a / b);
		     
			//Хващане на остатъка от целочислено деление 
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.WriteLine ("/n Резултат а%в=");
			Console.WriteLine (a % b);

			//Легендарното ++
			a=15;
			Console.Write (" /n Стара стойност а= ");
			Console.WriteLine (a);
			Console.WriteLine (" /n Използване на ++ ");
			a++;
			Console.Write (" /n Нова стойност а= ");
			Console.WriteLine (a);
	     	}
		}
	}
