using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instacia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (instacia == null)
                {
                    instacia = new Singleton();
                }
                return instacia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}