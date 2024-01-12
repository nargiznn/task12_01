using System;
namespace praktika12011
{
	public class Product
	{
		public Product(string name,double price)
		{
			Name = name;
			Price = price;
		}

		public string Name;
		public double Price;
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}

