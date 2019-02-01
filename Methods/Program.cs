/* Author: Nick Bove
   Date: 1/31/2019
   Comments: This C# Console application code demonstrates the use of methods
*/
using System;

namespace Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name");

			try
			{
				string input = Console.ReadLine();
				int value_of_input = int.Parse(input);

				int get_user_name = User_Name(value_of_input);
				Recommend_Exercise(get_user_name);
			}
			catch
			{
				Console.WriteLine("Press any key to exit the program..");
			}
		}

		private static int User_Name(int get_name);
		{
		int dispaly_name = get_name;
		return display_name;
		}
	}
}
