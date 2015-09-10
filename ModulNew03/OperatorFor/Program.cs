using System;

namespace OperatorFor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			for(int i=0;i<5;i++)
//			{
//				//код на цикъла за четене на индекс i в прав ред
//				Console.WriteLine (i.ToString());
//			} 
//
//			for(int i=5;i>0;i--)
//				{
//				//код на цикъла за четене на индекс i в обратен ред
//				Console.WriteLine (i.ToString());
//			    } 

			for(int i=0;i<=5;i+=2)
				{
				//код на цикъла за четене на четните индекси i
				Console.WriteLine (i.ToString());
				} 
		}
	}
}
