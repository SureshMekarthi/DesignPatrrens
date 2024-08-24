using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton5 obj3;
            Singleton5 obj4;

            //Parallel.Invoke(
            //   () => obj3 = Singleton5.Instance
            //   //() => obj4 = Singleton5.Instance
            //);

            //obj4 = Singleton5.Instance;

            DatabaseConnection obj1;
            DatabaseConnection obj2;

            obj1= DatabaseConnection.Instance;
            obj2 = DatabaseConnection.Instance;
        }
    }
}
