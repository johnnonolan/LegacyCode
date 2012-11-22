using System;

namespace TheMegaApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please pick your fave number");

			var choice = Console.ReadKey();
			int i;
			if (Int32.TryParse(choice.KeyChar.ToString(), out i))
			    Console.WriteLine ("it looks like you chose a number");
			else 
				Console.WriteLine ("You need to pick a number!");

			return;


		}
	}
}
