using System;
using System.Collections.Generic;
namespace Modul4list
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниции
			string _ui=" ";
			List <int> _list = new List <int> ();
			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//потребителски вход
			do{
				Console.Write ("?");
				_ui=Console.ReadLine();

			//преглед на List
				if (_ui.Contains("Show"))
				{
					Console.Write("_list:");
					for (int i=0;i<_list.Count;i++)
					{
						Console.Write(_list[i]);
						if (i!=_list.Count-1) Console.Write("");
					}
					Console.WriteLine();
				}
				//размер на List
			}while(_ui !="exit");
		}
		}
	}

