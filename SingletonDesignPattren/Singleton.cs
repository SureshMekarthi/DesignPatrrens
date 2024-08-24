using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattren
{
    public sealed class Singleton
    {
        private static Singleton createInstance = null;
        private static readonly object _lock = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (createInstance == null)
                {
                    lock (_lock)
                        if (createInstance == null)
                        {
                            createInstance = new Singleton();
                        }
                }
                return createInstance;
            }

        }

    }
}
