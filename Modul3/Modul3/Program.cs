using System;

namespace Modul3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Zadacha M-l3 Urok - 1

//			double a = 0, b = 0;
//			Console.Write ("-> a="); a = Convert.ToDouble (Console.ReadLine ());
//			Console.Write ("-> b="); b = Convert.ToDouble (Console.ReadLine ());
//
//			Console.WriteLine ("\n\n -> a / b= " +(a/b).ToString ("#0.00 m3"));


//			Zadacha M-l3 Urok - 2

			double a = 0, b = 0;
			Console.Write ("-> a="); a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("-> b="); b = Convert.ToDouble (Console.ReadLine ());

			string _format = "#0.00 m3";

			Console.WriteLine ("\n\n -> a / b= " +(a/b).ToString (_format));;
		}
	}
}
