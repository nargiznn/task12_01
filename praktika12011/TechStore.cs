using System;
namespace praktika12011
{
	public class TechStore
	{	
		public string Name;
		public Notebook[] Notebooks=new Notebook[0];
		public double TotalAmount;


		
		public void Add(Notebook notebook)
		{   
			Array.Resize(ref Notebooks, Notebooks.Length + 1);
		
			Notebooks[Notebooks.Length - 1] = notebook;
		}
		public Notebook Find(string name)
		{
			for(int i = 0; i < Notebooks.Length; i++)
			{
				if (Notebooks[i].Name == name)
					return Notebooks[i];
			}
			return null;
		}
		public void Sell(Notebook notebook)
		{ 
			TotalAmount += notebook.Price;
		}
	}
}

