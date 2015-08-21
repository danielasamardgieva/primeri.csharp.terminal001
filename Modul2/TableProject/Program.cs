using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = new string [3];
			row[0]="Ред 1";
			row[1]="Ред 2";
			row[2]="Ред 3";
			Console.WriteLine ("Масив row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n\n");

			//Дефинирам масив parse с разделител ,
			string [] parse = "a,b,c,d,e,f".Split(',');

			//Преброявам елементите в масива
			Console.WriteLine( "Броят на елементите в масива: \n" +"a,b,c,d,e,f \n\n e равен на: -->  "+parse.Length);

			//Събирам елементите на масива в стринг
			string list1=string.Join(";",parse);
			Console.WriteLine( "Новият стринг е: \n"+list1+"\n\n");
		}
	}
}
