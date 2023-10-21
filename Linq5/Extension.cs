using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq5
{
	public static class Extension
	{
		public static IEnumerable<T> Paginate<T>
			(this IEnumerable<T> Source,int page=1,int size=10) where T : class
		{
			if(page <= 0) 
				page = 1;

			if (size <= 0)
				size = 10;
			var total=Source.Count();
			
			if (size < total)
			{
				size = total;
			}
			var Pages=(int)Math.Ceiling((decimal)total/size);
			var Result = Source.Skip((page - 1) * size).Take(size);
			return Result;
		}
	}
}
