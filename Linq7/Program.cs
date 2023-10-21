using LINQTut07.Shared;
using System.ComponentModel.DataAnnotations;

namespace Linq7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employees=Repository.LoadEmployees();
			var e = new Employee()
			{
				EmployeeNo = "2017-FI-1343",
				Name = "Cochran Cole",
				Email = "Cole.Cochran01@example.com",
				Salary = 1032,
				Skills = new() { "Javascript", "C++", "NodeJS" }

			};

			var list = employees.Contains(e); 
			Console.WriteLine(list);

	
		}
	}
}