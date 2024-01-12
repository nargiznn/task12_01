using System;

namespace praktika12011
{
    class Program
    {
        static void Main(string[] args)
        { TechStore store = new TechStore();
            string opt;
            do
            {
                Console.WriteLine("1.Notebook elave edin");
                Console.WriteLine("2.Notebook sat");
                Console.WriteLine("3.TotalAmounta bax");
                Console.WriteLine("0. Cix");

                Console.WriteLine("Emeliyyat secin");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Notebook adi daxil edin");
                        string name = Console.ReadLine();
                        if (store.Find(name) != null)
                        {
                            Console.WriteLine("yanlisdi");
                            break;
                        }
                        Console.WriteLine("Qiymet daxil edin");
                        double price;
                        if (double.TryParse(Console.ReadLine(), out price))
                        {
                            Notebook ntw = new Notebook(name, price);
                            store.Add(ntw);
                        }
                        else
                        {
                            Console.WriteLine("Yanlisdir");
                        }
                        break;

                    case "2":
                        for(int i=0;i<store.Notebooks.Length;i++)
                        {
                            Console.WriteLine(store.Notebooks[i]);
                        }
                        Console.WriteLine("Notebooku secin:");
         
                        int selectntbIndex;
                        if (int.TryParse(Console.ReadLine(), out selectntbIndex) &&
                            selectntbIndex > 0 && selectntbIndex <= store.Notebooks.Length)
                        {
                            Notebook selectNtb = store.Notebooks[selectntbIndex - 1];

                            if (store.Find(selectNtb.Name) == null)
                            {
                                Console.WriteLine("Bele bir mehsul yoxdu");
                            }
                            else
                            {
                                store.Sell(selectNtb);
                                Console.WriteLine($"{selectNtb} satildi");
                            }
                        }
                        else
                        {
                            Console.WriteLine("yeniden daxil edin");
                        }
                        break;

                    
                    case "3":
                        Console.Write("TotalAmount: ");
                        Console.WriteLine(store.TotalAmount);
                        break;
                    case "0":
                        Console.WriteLine("Emeliyyat bitmisdi");
                        break;
                    default:
                        Console.WriteLine("Emeliyyat yanlisdi!");
                        break;
                }
            }

            while (opt != "0");
            
        }
    }
}

