using Shared;
using System.Linq.Expressions;

namespace Linq10
{
	public class Program
	{
		static void Main(string[] args)
		{
			Expression<Func<int, bool>> IsEventExp = num => num % 2 == 0;


			ParameterExpression p = IsEventExp.Parameters[0];
			BinaryExpression operatorr =(BinaryExpression) IsEventExp.Body;
		}
	}
}
