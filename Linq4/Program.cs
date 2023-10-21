using LINQTut04.SELECT;
using LINQTut04.Shared;

namespace Linq4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Example2();
		}
	    private static void Example1()
		{
			var Employees = Repository.LoadEmployees();
			var Result= Employees.Select(c =>
			{
				return new EmployeeDto()
				{
					Name = c.FirstName + "  " + c.LastName,
					TotalSkills=c.Skills.Count()
				};
			});


			foreach (var Employee in Result)
			{
				Console.WriteLine(Employee);
			}



		}

		private static void Example2()
		{

			var Names=new List<string>() { "Ahmed","Sameh","Ali"};
			var Ages=new List<string>() { "23","47","21"};

			var Data = Names.Zip(Ages, (name,age) =>
			{
				return name + " " + age;
			});

			foreach (var item in Data)
			{
				Console.WriteLine(item);
			}
		}
	}

}