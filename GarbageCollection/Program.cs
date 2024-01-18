namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Play newPlay = new Play("Chasing two birds with one stone", "Mikhail Staritsky", "comedy", 1883)) 
            { 
            newPlay.CallName();
            newPlay.ChangeName("Winter evening");
            }
            Console.WriteLine("\n");
            using(Shop newShop = new Shop("CofeeStore", "Vesnina 24",ShopType.glocery ))
            { 
            newShop.CallName();
            }
        }
    }
}