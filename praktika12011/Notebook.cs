using System;
namespace praktika12011
{
	public class Notebook:Product
	{
		public Notebook(string name,double price):base(name,price)
		{
            this.Price = price;
            this.Name = name;
		}
        public Notebook(string name, double price, int storage) : base(name, price)
        {
            Storage = storage;
        }
        public int Storage;
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price} ";
        }
    }
}

