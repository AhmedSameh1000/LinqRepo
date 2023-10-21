using LINQTut17.Data;

namespace Linq11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var Context = new BookContext();
			//var Books=Context.Books.Where(c=>c.Id<10);
			//IQueryable<Book> IQuerable=Context.Books;
			IEnumerable<Book> IEnumerable = Context.Books;


			var Books = IEnumerable.Where(v => v.Id < 10);



			foreach (var Book in Books)
			{
				Console.WriteLine(Book);
			}





		}
	}
}