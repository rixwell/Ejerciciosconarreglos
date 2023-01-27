   int[] numeros = new int[10];
    int[] factoriales = new int[10];


    for (int i = 0; i < 10; i++) {
      Console.Write("Ingresa un número entero: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }


    for (int i = 0; i < 10; i++) {
      factoriales[i] = Factorial(numeros[i]);
    }


    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Factorial de " + numeros[i] + " es " + factoriales[i]);
    }

 static int Factorial(int numero)
 { 
    if (numero == 0) {
      return 1;
    }
    int resultado = 1;
    for (int i = 1; i <= numero; i++)
    {
        resultado *= i;
    }
    return resultado;
}
Console.ReadKey();