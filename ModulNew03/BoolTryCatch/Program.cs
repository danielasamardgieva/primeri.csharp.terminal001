using System;

namespace BoolTryCatch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };

			int _ui = 0;
			string _input = "0";

			Console.WriteLine ("Въведете номер на елемент в редицата-->");
			_input = Console.ReadLine ();

			bool _check01 = int.TryParse (_input, out _ui);

			try
				{
				Console.WriteLine("Елемент "+_ui.ToString()+" от масива е:");
					Console.WriteLine (_i [_ui - 1]);
			}catch{
				Console.WriteLine (" <недефиниран елемент> ");
				} 

		}
	}
}
