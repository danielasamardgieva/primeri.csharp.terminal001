using System;

namespace ModulNew03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
	            
//		    	Zadacha M-l3 Urok - 1

//				double a = 0, b = 0;
//				Console.Write ("-> a="); a = Convert.ToDouble (Console.ReadLine ());
//				Console.Write ("-> b="); b = Convert.ToDouble (Console.ReadLine ());
//		
//					Console.WriteLine ("\n\n -> a / b= " +(a/b).ToString ("C2"));
//

//				 Zadacha M-l3 Urok - 2
//
//			double a = 0, b = 0;
//			Console.Write ("-> a="); a = Convert.ToDouble (Console.ReadLine ());
//			Console.Write ("-> b="); b = Convert.ToDouble (Console.ReadLine ());
//
//			string _format = "#0.00 m3";
//
//			Console.WriteLine ("\n\n -> a / b= " +(a/b).ToString (_format));

//              Zadacha M-L3 Urok 3
//			Степенуване
			double a = 0, b = 0, c=0;
			Console.Write ("-> a="); a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("-> b="); b = Convert.ToDouble (Console.ReadLine ());

//			Форматиране с дименсия
			string _format = "#0.00 m3";

//			Степенуване
			c = Math.Pow(a,b);
			Console.WriteLine ("\n\n -> a ^ b= " +c.ToString (_format));

//			Коренуване
			c = Math.Sqrt(b);
			Console.WriteLine ("\n\n ->  b^ 1/2 = " +c.ToString (_format));

//			Закръгление
			c = Math.Round(a/b);
			Console.WriteLine ("\n\n ->  a/b = " +c.ToString ());
		}
	}
}
