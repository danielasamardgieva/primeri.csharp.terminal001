using System;

namespace VlaganeNaFor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = 
			{
				{"Иван","Георгиев","19"},
				{"Петър","Маринов","24"},
				{"Филип","Николов","45"},
				{"Валя","Стоянова","32"},
				{"Асен","Серафимов","51"},
				{"Митко","Димитров","25"}
			};

			//Антетка

			Console.WriteLine("Име".PadRight(12)+"Фамилия".PadRight(12)+"Години".PadRight(12));
			Console.WriteLine("================================================");

			//Тяло на таблицата

			for (int i = 0; i < _table.Length / 3; i++) 
				{
				for (int j = 0; j < 3; j++)
				{
					
					Console.Write(_table [i, j].PadRight (12));

				}
				Console.WriteLine ();
			}
		}
	}
}
