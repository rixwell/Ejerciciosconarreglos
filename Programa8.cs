int[] arr = new int[10];
        int conteonegativo = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduzca un numero entero: ");
            arr[i] = int.Parse(Console.ReadLine());

            
            if (arr[i] < 0)
            {
                conteonegativo++;
            }
        }


        Console.WriteLine("Existen " + conteonegativo + " números negativos en la matriz.");
   


