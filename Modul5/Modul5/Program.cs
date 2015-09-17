using System;

namespace Modul5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string usercomand = " ";

			//потребителски команди
			do {
				Console.Write ("$ "); usercomand=Console.ReadLine ();

				if (usercomand.Contains ("cmd01")) cmd01 (usercomand);
				if (usercomand.Contains ("cmd02")) cmd02 (usercomand);
				} while(usercomand !="exit");
		   }
			public static void cmd01(string _input) //cmd01 5 -->5^2
			{ 
			try
				{
				double _temp = 0;
				if (double.TryParse (_input.Split (' ') [1], out _temp)) 
					{
					Console.WriteLine (("Резултат на втора степен--->" + (_temp * _temp).ToString ()));
					}
				} catch {

						}
			}
			public static int cmd02(string _input) //cmd2 командата повдига на 3-та степен числото след нея
				{
			int _temp = 0;
			if (int.TryParse (_input.Split (' ') [1], out _temp))
					{
				Console.WriteLine("Резултат на трета степен ---------->"+(_temp * _temp*_temp).ToString ());
					}
			return _temp;
				}
	}
}
