using System;

namespace DestructorExample
{
    public class MyClass : IDisposable
    {
        private bool disposed = false;

        ~MyClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here...
                    Console.WriteLine("Disposing managed resources...");
                }

                // Dispose unmanaged resources here...
                Console.WriteLine("Disposing unmanaged resources...");

                disposed = true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Dispose(); // Manually calling the Dispose method
        }
    }
}
