using System;

namespace napred2nazad1do10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//покажете napred 2 nazad 1do 10
			int i=0;
			bool napred=true;
			while(i < 10) {
				if (napred) {
					napred=false;
					i+=2;
				} else {
					napred=true;
					i--;
				}
				Console.WriteLine(i);
		

		}
	}
}
