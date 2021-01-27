using System;
using System.ComponentModel;

namespace Singleton
{
    public class MaquinaHelloWorld
    {
        private static MaquinaHelloWorld instance = null;

        private MaquinaHelloWorld(){}

        public static MaquinaHelloWorld Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MaquinaHelloWorld();
                }

                return instance;
            }
        }

        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
