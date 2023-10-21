using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq9
{
	internal class EmployeeDto
	{
		public string FullName { get; set; }
		public string DepartmentName { get; set; }

		public override string ToString()
		{
			return $"{FullName} [{DepartmentName}]";
		}
	}
}
