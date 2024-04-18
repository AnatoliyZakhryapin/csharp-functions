namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Seleziona opzione:");
                Console.WriteLine();
                Console.WriteLine("1. Voglio uttilizzare arrayDefault");
                Console.WriteLine("2. Voglio creare io array");
                Console.WriteLine();
                Console.WriteLine("0. Esci");

                // Prendiamo l'input dell'utente
                string input = Console.ReadLine();

                // Converte l'input in un numero intero
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            // Uscita dal programma
                            return;
                        case 1:
                            useArrayDefault();
                            break;
                        case 2:
                            useArrayCustom();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input non valido. Riprova.");
                }
            }

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

            void Snack1(int[] array)
            {
                // -------
                // Snack 1
                // -------

                Console.WriteLine();
                Console.WriteLine("Snack 1");

                StampaArray(array);

                Console.WriteLine();
            }

            void Snack2(int[] array)
            {
                // -------
                // Snack 2
                // -------

                Console.WriteLine();
                Console.WriteLine("Snack 2");

                StampaArray(ElevaArrayAlQuadrato(array));
                Console.WriteLine();

                StampaArray(array);
                Console.WriteLine();
            }

            void Snack3(int[] array)
            {
                // -------
                // Snack 3
                // -------

                Console.WriteLine();
                Console.WriteLine("Snack 3");

                Console.WriteLine($"La somma dell'array: {SommaElementiArray(array)}");
            }

            void Snack4(int[] array)
            {
                // -------
                // Snack 4
                // -------

                Console.WriteLine();
                Console.WriteLine("Snack 4");

                Console.WriteLine($"La somma dell'array con i numeri elevati al quadrato: {SommaElementiArray(ElevaArrayAlQuadrato(array))}");
            }

            void SnackChoice(int[] array)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Seleziona uno snack da eseguire:");
                    Console.WriteLine();
                    Console.WriteLine("1. Snack 1");
                    Console.WriteLine("2. Snack 2");
                    Console.WriteLine("3. Snack 3");
                    Console.WriteLine("4. Snack 4");
                    Console.WriteLine();
                    Console.WriteLine("0. Esci");

                    // Prendiamo l'input dell'utente
                    string input = Console.ReadLine();

                    // Converte l'input in un numero intero
                    if (int.TryParse(input, out int choice))
                    {
                        switch (choice)
                        {
                            case 0:
                                // Uscita dal programma
                                return;
                            case 1:
                                Snack1(array);
                                break;
                            case 2:
                                Snack2(array);
                                break;
                            case 3:
                                Snack3(array);
                                break;
                            case 4:
                                Snack4(array);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input non valido. Riprova.");
                    }
                }
            }

            void useArrayDefault()
            {
                int[] arrayDefault = { 2, 6, 7, 5, 3, 9 };

                SnackChoice(arrayDefault);
            }

            void useArrayCustom()
            {
                // -------
                // BONUS
                // -------
                Console.WriteLine();
                Console.WriteLine("Bonus");

                Console.WriteLine();
                Console.WriteLine("Crea il tuo array personalizzato.");

                int numberOfelement;
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Inserisci la quantita di elementi dell'array:");

                    // Salviamo input 
                    string userInput = Console.ReadLine();

                    try
                    {
                        numberOfelement = Convert.ToInt32(userInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine($"Quantita di elementi inserita è: {numberOfelement}");

                int[] arrayCustom = new int[numberOfelement];

                Console.WriteLine();
                Console.WriteLine("Adesso devi inserire il numero per ogni elemento dell'array");
                for (int i = 0; i < numberOfelement; i++)
                {
                   
                    while (true)
                    {
                        Console.WriteLine();
                        Console.Write($"Elemento {i + 1} : numero = ");

                        // Salviamo input 
                        string userInput = Console.ReadLine();

                        try
                        {
                            arrayCustom[i] = Convert.ToInt32(userInput);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Errore di formato. Inserisci un numero valido, NON puo contenere le lettere o simboli!.");
                        }
                    }
                }

                SnackChoice(arrayCustom);
            }
           
        }

    }
}
