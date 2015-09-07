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
			int[] _i = new int[] { 4, 3, 2 };

			Console.WriteLine ("Въведете номер на елемент в редицата-->");

//          Променливата съхранява номера на елемента в редицата
			int _ui = Convert.ToInt32 (Console.ReadLine ());

			if (_ui > 0 && _ui <= _i.Length) {
				Console.WriteLine (_i [_ui - 1]);
			} else {
				if (_ui > _i.Length)
					Console.WriteLine ("Индексът е по-голям \n");
			}
			if (_ui <= 0) {
				Console.WriteLine ("Индексът е по-малък\n");
			}
		}
	}
}

//  		Проверки за двата края на редицата, ако стойностите са true - добре е 
//			bool _check01=_ui<=_i.Length;
//			bool _check02 = _ui > 0;
//
//			bool _exp01 = _check01 && _check02;   //лог. И "&&"
//			bool _exp02=_check01 || _check02;     //Лог. ИЛИ "||"
//			bool _exp03=!_check01 ;                //Лог. НЕ "!"
//				
//
//			Console.WriteLine("Логическо И-->" + _exp01.ToString());
//			Console.WriteLine("Логическо ИЛИ-->" + _exp02.ToString());
//			Console.WriteLine("Логическо НЕ-->" + _check01.ToString()+":"+_exp03);

//          Елемент с номер, зададен от клав. е:
//			Console.WriteLine(_i[_ui-1]);
