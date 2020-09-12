using System;
using System.Collections.Generic;

namespace Exceptions
{

	class Program
	{

		static void Main(string[] args)
		{
			//try
			//{
			//	Console.WriteLine("Pick a number.");
			//	int numberOne = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine("Pick a second number.");
			//	int numberTwo = Convert.ToInt32(Console.ReadLine());
			//	Console.WriteLine("dividing the two");
			//	int numberThree = numberOne / numberTwo;
			//	Console.WriteLine(numberOne + " divided by" + numberTwo + " equals " + numberThree);
			//	Console.ReadLine();
			//}
		//catch (FormatException ex)
			//{
			//	Console.WriteLine("Please type a whole number.");
			//	return;	
			//}
			//catch(DivideByZeroException ex)
			//         {
			//	Console.WriteLine("Please dont divide by zero");
			//         }
			//catch (Exception ex)
			//         {
			//	Console.WriteLine(ex.Message);
			//         }
			//finally
			//{
			//Console.ReadLine();
			//      }
			//Console.ReadLine();

			List<int> numbers = new List<int>() { 2, 3, 6, 9, 15, 4 };
			try
			{
				Console.WriteLine("Please choose a number to divide by");
				int div = Convert.ToInt32(Console.ReadLine());

				foreach (int num in numbers)
				{
					Console.WriteLine("your number divided by the computer number is equal to  " + num / div);
				}
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Please type a whole number.");
				return;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Please dont divide by zero");
				return;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.ReadLine();
			}
			


			

		}

	}
}
