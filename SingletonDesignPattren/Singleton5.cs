using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattren
{
    public sealed class Singleton5
    {
        private Singleton5() { }

        private static readonly Lazy<Singleton5> lazy = new Lazy<Singleton5>(() => new Singleton5());
        public static Singleton5 Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
