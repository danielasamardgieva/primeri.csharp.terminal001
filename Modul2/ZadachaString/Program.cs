using System;

namespace ZadachaString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Задача 01
			//Дефиниране на променливи от тип стринг
			string first = "Hello";
			string second = "World";

			//Събиране на променливи от тип стринг в нов обект
			object concatenatedString = first + " " + second;
			//нов стринг
			string newString = (string)concatenatedString;
			Console.WriteLine (newString);


			//Задача02
			//Дефиниране на променливи 
			int a = 0;

			string bb = "BBB";

			//Въвеждане на стойности от ком.ред
			Console.Write ("Моля въведете а:");
			a=Console.Read ();
			string aa = Convert.ToString (a);

			Console.Write ("Моля въведете дума:");
			bb= Console.ReadLine ();
			Console.WriteLine (bb);

			//Резултат

			Console.WriteLine ("Нов израз: "+aa);

		}


		}

	}


 