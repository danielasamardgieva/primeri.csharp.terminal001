using System;

namespace Modul4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//for(int i=0;i<5;i++)
			//			{
			//				//код на цикъла за четене на индекс i
			//				Console.WriteLine (i.ToString());
			//			} 

			string[] _table = { "Иван", "Гошо", "Пешо" };
			//Антетка на тавлицата
			Console.WriteLine("Име");
			Console.WriteLine("==================================");

			//Тяло на таблицата
			for (int i = 0; i < _table.Length; i++) {
				//Код на цикъла
				Console.WriteLine (_table [i]);
			}
		}
	}
}
