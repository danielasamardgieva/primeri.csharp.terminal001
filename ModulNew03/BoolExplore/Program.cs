using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{


//          Да се прочете елемент от редица като потребителя зададе от клав. неговиа номер
//          Въвеждам редица от 3 елемента
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;
			string _input = "0";

			Console.WriteLine ("Въведете номер на елемент в редицата-->");
			_input = Console.ReadLine ();

			bool _check01 = int.TryParse (_input, out _ui);
			bool _check02 = _ui <= _i.Length;
			bool _check03 = _ui > 0;

			if (_check01 && _check02 && _check03)
			{
				Console.WriteLine (_i [_ui - 1]);
			} 
			if (!_check01) {
				Console.WriteLine ("Индексът трябва да бъде цяло число \n\n");
			}
			if (!_check02)
			{
				Console.WriteLine ("Индексът е по-голям \n");
			}
			if (!_check03 && _check01) {
				Console.WriteLine ("Индексът е по-малък\n");
			}
		}
	}
}

