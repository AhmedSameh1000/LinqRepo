using LINQTut05.Shared;

namespace Linq5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var Employee=Repository.LoadEmployees();
			int page = 1;
			int pageSize = 10;
			var res=Employee.Paginate(page,pageSize);
			var data=Extension.Paginate(Employee,page,pageSize);
			data.Print("Data With Pagination");
		}
	}
}