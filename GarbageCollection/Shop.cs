using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public enum ShopType
    {
        glocery,
        hardware,
        cloth,
        shoes
    }
    internal class Shop:IDisposable
    {
        public string Name { get; set; }
        public string AddressOfShop { get; set; }
        public ShopType ShopType { get; set;}
        private bool disposed = false;
        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            AddressOfShop = address;
            ShopType = type;
        }
        public void CallName()
        {
            Console.WriteLine($"Name of the shop: {Name}, address of the shop: {AddressOfShop}, type of the shop: {ShopType}");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"{Name} has been disposed.");
            }
            disposed = true;
        }
        ~Shop()
        {
            Dispose(false);
        }
    }
}
