using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    internal class Play:IDisposable
    {
        public string Name { get; set; }    
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        private bool disposed = false;
        public Play (string name, string authorName, string genre, int year)
    {
        Name = name;
        AuthorName = authorName;
        Genre = genre;
        Year = year;
    }
        public void CallName()
        {
            Console.WriteLine($"Name of the piece: {Name}, author of the piece: {AuthorName}, genre of the piece: {Genre}, year of the piece: {Year}");
        }
        public void ChangeName(string NewName)
        {
            Name = NewName;
            Console.WriteLine($"The name of the play is: {Name}");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"{Name} has been disposed.");
            }
            disposed = true;
        }
        ~Play()
        {
            Dispose(false);
        }
    }
}
