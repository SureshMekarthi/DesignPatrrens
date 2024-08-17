using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatrrens
{
    public sealed class Singleton1 : IDisposable
    {
        private static readonly object _lock = new object();
        private bool _disposed = false;
        private static Singleton1 _instance = null;
        private Singleton1()
        {

        }
        private static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton1();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected dispose method to allow subclassing
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here
                }

                // Dispose unmanaged resources here

                _disposed = true;
            }
        }

        // Destructor
        ~Singleton1()
        {
            Dispose(false);
        }

        public static void ResetInstance()
        {
            lock (_lock)
            {
                _instance?.Dispose();
                _instance = null;
            }
        }

    }


}

