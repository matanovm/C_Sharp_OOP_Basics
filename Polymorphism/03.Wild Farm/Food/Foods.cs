namespace _03.Wild_Farm.Food
{
	public abstract class Foods
	{
		public Foods(int quantity)
		{
			Quantity = quantity;
		}

		public int Quantity
		{
			get;
			set;
		}
	}
}
