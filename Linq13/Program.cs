using Shared;

namespace Linq13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employees=Repository.Employees;


			int page = 1;
			int pageSize = 10;
			var SearchString = "j";

			var page1=employees.Pagination10(page, pageSize,c=>c.FirstName.Contains(SearchString));
			


			page1.Values.Print($"Employees in Page {page}");

			
		}
	}
}