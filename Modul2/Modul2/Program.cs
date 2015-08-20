using System;

namespace Modul2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0, sum=0;
			string programe_name = "Modul02 - Примери";
			string programe_version = "1.0";

			//За програмата
			Console.WriteLine (programe_name);
			Console.WriteLine ("Версия: " +  programe_version + "\n\n");

			//Събиране на числа
			a = 10;
			b = 5;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			sum = a + b;
			Console.Write ("\n Сумата е ----> sum=");
			Console.WriteLine (sum + "\n\n");
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.Write ("Резултат а+в=");
			a += b;
			Console.WriteLine (a + "\n\n");

			//Изваждане на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.Write ("\n Резултат а-в=");
			a -= b;
			Console.WriteLine (a + "\n\n");
		
			//Умножение на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.Write ("\n Резултат а*в=");
			a *= b;
			Console.WriteLine (a + "\n\n");

			//Стандартно=Целочислено деление на числа
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.Write ("\n Резултат а/в=");
			Console.WriteLine (a / b + "\n\n");
		     
			//Хващане на остатъка от целочислено деление 
			a = 15;
			b = 10;
			Console.Write (" a = ");
			Console.WriteLine (a);
			Console.Write (" b = ");
			Console.WriteLine (b);
			Console.Write ("\n Резултат а%в=");
			Console.WriteLine (a % b + "\n\n");

			//Легендарното ++
			a=15;
			Console.Write (" /n Стара стойност а= ");
			Console.WriteLine (a);
			Console.WriteLine (" \n Използване на а++ ");
			a++;
			Console.Write (" \n Нова стойност а= ");
			Console.WriteLine (a);
	     	}
		}
	}
