using LINQTut03.Shared;

namespace Linq3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var number = new List<int> { 1, 2, 3, 4, 5 };

			var evenNumbers = number.Where(c => c % 2 == 0);


			evenNumbers = evenNumbers.Where(c => c > 2);

			number.Add(6);

			foreach (var item in evenNumbers)
			{
				Console.WriteLine(item);
			}
		
		}

	}


}

