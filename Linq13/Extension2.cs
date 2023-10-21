using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq13
{
	public static class Extension2
	{
		public static void Print<T>(this IEnumerable<T> source, string title)
		{
			if (source == null)
				return;
			Console.WriteLine();
			Console.WriteLine("┌───────────────────────────────────────────────────────┐");
			Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
			Console.WriteLine("└───────────────────────────────────────────────────────┘");
			Console.WriteLine();
			foreach (var item in source)
			{
				if (typeof(T).IsValueType)
					Console.Write($" {item} "); // 1, 2, 3
				else
					Console.WriteLine(item);
			}
		}


		//public static paginationResult<Employee> 
		//	Pagination()
		//{

		//}



		public static IEnumerable<T>
	    Pagination<T>(this IEnumerable<T> Source,int page=1,int pageSize=10,Predicate<bool> Search=null)
		{
			if(Source is null)
				throw new ArgumentException(nameof(Source));

			if(page<=0)
				throw new ArgumentException(nameof(page));

			if(pageSize<=0)
				throw new ArgumentException(nameof(page));

			if(!Source.Any())
				return Enumerable.Empty<T>();

			var result = Source.Skip((page - 1) * pageSize).Take(pageSize);

			if (Search != null)
			{
				
			}

			return result;

		}


		public static paginationResult<T> Pagination10<T>(this IEnumerable<T> Source, int page = 1, int pageSize = 10, Predicate<T> search = null!)
		{
			if (Source is null)
				throw new ArgumentException(nameof(Source));

			if (page <= 0)
				throw new ArgumentException(nameof(page));

			if (pageSize <= 0)
				throw new ArgumentException(nameof(pageSize));


			if (search != null)
			{
				Source = Source.Where(item => search(item));
			}
			var result = Source.Skip((page - 1) * pageSize).Take(pageSize);

			var pagination = new paginationResult<T>()
			{
				page = page,
				pageSize = pageSize,
				total=Source.Count(),
				Values=Source
			};
			return pagination;
		}




	}
}
