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

        }

    }
}
