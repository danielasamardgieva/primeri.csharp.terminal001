using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Декларирам таблицас 2 реда и 3 колони
			string[,]table=new string[2,3];
			//Въвеждам данни за 1 ред:
			table[0,0]="Мартин";table[0,1]="Симеонов";table[0,2]="31";

			//Въвеждам данни за 2 ред:
			table[1,0]="Симеон";table[1,1]="Мартинов";table[1,2]="41";

			//Извеждаме 1-ви символ от 1-ви елемент, 2-ри и 3-ти ел-т:
			//Console.WriteLine((table[0,0])[0]+". "+table[0,1]+", "+table[0,2]);

			//Извеждам ред по избор от клавиатурата (1-ви или 2-ри)
			Console.Write("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;
			Console.WriteLine((table[_index,0])[0]+". "+table[_index,1]+", "+table[_index,2]);


//          string[] row = new string [3];
//			row[0]="Ред 1";
//			row[1]="Ред 2";
//			row[2]="Ред 3";
//			Console.WriteLine ("Масив row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n\n");
//
//			//Дефинирам масив parse с разделител ,
//			string [] parse = "a,b,c,d,e,f".Split(',');
//
//			//Преброявам елементите в масива
//			Console.WriteLine( "Броят на елементите в масива: \n" +"a,b,c,d,e,f \n\n e равен на: -->  "+parse.Length);
//
//			//Събирам елементите на масива в стринг
//			string list1=string.Join(";",parse);
//			Console.WriteLine( "Новият стринг е: \n"+list1+"\n\n");
		}
	}
}
