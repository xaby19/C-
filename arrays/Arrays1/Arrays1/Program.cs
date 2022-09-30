namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] array5 = { 23, 43, 1, -3, 6};
            EscribeArray5(array5);
            Console.WriteLine();
            int[] array = { 23, 43, 1, -3, 6, 45, 2 };
            EscribeArray(array);
            Console.WriteLine();
            int[] emptyArray = {};
            EscribeArray(emptyArray);

        }

        static void EscribeArray5(int[] array5)
        {
            /*
            Escribe una función “EscribeArray5” a la que le pasamos un array de tipo entero de cinco elementos y
            lo escribe por pantalla de la siguiente forma: [23, 43, 1, -3, 6] 
            */
            Console.Write("[");
            for (int i = 0; i < array5.Length - 1; i++)
            {
                Console.Write($"{array5[i]}, ");
            }
            Console.Write($"{array5[4]}]");
                
        }

        static void EscribeArray(int[] array)
        {
            /*
             2. Escribe una función “EscribeArray” a la que le pasamos un array de enteros del tamaño 
                que sea y lo escribe por pantalla de la misma forma. Tendremos que usar la propiedad 
                “Length” para saber el tamaño del array desde dentro de la función.
             */
            if (array.Length != 0)
            {

                Console.Write("[");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.Write($"{array[array.Length - 1]}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }
}