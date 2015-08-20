using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a=5, b=0;

			//Въвеждане на входни параметри
			Console.Write ("Моля въведете а= ");
			b = Convert.ToInt32 (Console.ReadLine () );


			//Печат на резултата
			Console.Write ("Резултат а+b=" + (a+b).ToString ()+ "\n\n");

			//Работа със стринг
			string test=" 1";
			test += " ,2";
			test +=" ,100";
			test +=" ,4";
			test +=" ,5";
			Console.WriteLine ("Събиране с += " + test + "\n");

			//Замяна на сепаратор , с ;
			test=test .Replace(" ,", ";");
			Console.WriteLine ("Работа с Replase:" + test + "\n");

			//търсене на елемент в редицата
			Console.WriteLine("3-ти елемент в редицата:" + test.Split (';')[2]);
				}	
	}
}
