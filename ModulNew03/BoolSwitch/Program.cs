using System;

namespace BoolSwitch
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

			switch (_ui) {
			case 1:
				{
				Console.WriteLine("1ви елемент в масива:");
				Console.WriteLine (_i [_ui - 1]);
			break;
				} 
			
				case 2:
				{
				Console.WriteLine("2ри елемент в масива:");
				Console.WriteLine (_i [_ui - 1]);
				break;
				} 

				case 3:
				{
				Console.WriteLine("3ти елемент в масива:");
				Console.WriteLine (_i [_ui - 1]);
				break;
			} 
			default:
			{
                Console.WriteLine("В масива няма стойност за този индикс\n Опитайте с индекс между 1 и 3\n");
				break;
			} 
		}
		}
	}}
	
