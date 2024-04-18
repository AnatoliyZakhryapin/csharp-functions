namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }
                Console.Write("]");
            }

            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }

            int Quadrato(int numero)
            {
                return numero * numero;
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] nuovoArray = new int[array.Length];
                //int[] nuovoArray = (int[])array.Clone();

                for (int i = 0; i < array.Length; i++)
                {
                    nuovoArray[i] = Quadrato(array[i]);
                }
                return nuovoArray;
            }

            int SommaElementiArray(int[] array)
            {
                int sum = array.Sum();

                return sum;
            }

            int[] arrayDefault = { 2, 6, 7, 5, 3, 9 };


            // -------
            // Snack 1
            // -------

            Console.WriteLine("Snack 1");

            StampaArray(arrayDefault);

            Console.WriteLine();

            // -------
            // Snack 2
            // -------

            Console.WriteLine("Snack 2");

            StampaArray(ElevaArrayAlQuadrato(arrayDefault));
            Console.WriteLine();
            
            StampaArray(arrayDefault);
            Console.WriteLine();

            // -------
            // Snack 3
            // -------

            Console.WriteLine("Snack 3");

            Console.WriteLine($"La somma dell'array: {SommaElementiArray(arrayDefault)}");

            // -------
            // Snack 4
            // -------

            Console.WriteLine("Snack 4");

            Console.WriteLine($"La somma dell'array con i numeri elevati al quadrato: {SommaElementiArray(ElevaArrayAlQuadrato(arrayDefault))}");
        }

    }
}
