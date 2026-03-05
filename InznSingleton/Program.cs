using System;

namespace Wzorce_Projektowe
{
 
    public class Szkola
    {
        private static Szkola _instance;

 
        private Szkola()
        {
        }

        public static Szkola getInstance()
        {
            if (_instance == null)
            {
                _instance = new Szkola();
            }

            return _instance;
        }


        public void wyswietlNapis()
        {
            Console.WriteLine("Szkola w Pcimiu jest najlepsza na świecie");
        }

        public unsafe void wyswietlID()
        {
            TypedReference tr = __makeref(_instance);
            IntPtr ptr = **(IntPtr**)(&tr);
            Console.WriteLine("Adres obiektu w pamieci: " + ptr);
        }
    }

    class Singleton_Test
    {
        public static void Main()
        {
            Console.WriteLine("Rozpoczecie programu Singleton");
            Szkola.getInstance().wyswietlID();
            Szkola.getInstance().wyswietlNapis();
            Console.WriteLine("_____________");

            drugaFunkcja();

            Console.WriteLine("_____________");
        }

        static void drugaFunkcja()
        {
            Console.WriteLine("Rozpoczecie drugiej funkcji");
            Szkola.getInstance().wyswietlID();
            Szkola.getInstance().wyswietlNapis();
        }
    }
}