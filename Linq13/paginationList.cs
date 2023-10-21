﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq13
{
	public class paginationResult<T>
	{
		public int page { get; set; } = 1;
		public int pageSize { get; set; } = 10;
		public int total { get; set; }
		
		public IEnumerable<T> Values { get; set; }
	}
}
