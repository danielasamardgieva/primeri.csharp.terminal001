using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Булевата променлива има само едната от две стойности: true or false 
//			bool _b = true;
//			Console.WriteLine (_b);

//			Въпрос 5>10 има логически отговор
//			bool _test = 5 > 10;
//			Console.WriteLine (_test);

//          Да се прочете елемент от редица като потребителя зададе от клав. неговиа номер
//          Въвеждам редица от 3 елемента
			int [] _i=new int[] {4, 3,2};

			Console.WriteLine("Въведете номер на елемент в редицата-->");

//          Променливата съхранява номера на елемента в редицата
			int _ui=Convert.ToInt32(Console.ReadLine ());

//			Проверки за двата края на редицата, ако стойностите са true - добре е 
			bool _check01=_ui<=_i.Length;
			bool _check02 = _ui > 0;

//          В булевите променливи се пазят границите на редицатаМ
			Console.WriteLine(_check01);
			Console.WriteLine(_check02);

//          Елемент с номер, зададен от клав. е:
			Console.WriteLine(_i[_ui-1]);
		}
	}
}
