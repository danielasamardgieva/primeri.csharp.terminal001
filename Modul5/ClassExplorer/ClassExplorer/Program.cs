using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString="тестова променлива от клас";

		public person ()
		{
			simpleString = "Промяна на променливата при инициализация";
		}



	}


	class MainClass
	{
		
		public static void Main (string[] args)
		{
			//Дефиниране на клас
			person _person=new person ();

			//Достъпване на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
