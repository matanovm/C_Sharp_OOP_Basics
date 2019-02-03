namespace _02.Book_Shop
{
	class GoldenEditionBook : Book
	{
		protected override decimal Price
		{
			get
			{
				return base.Price * 1.3M;
			}
		}

		public GoldenEditionBook(string author, string title, decimal price)
			: base(author, title, price)
		{

		}
	}
}
