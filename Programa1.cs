int[] numeros = new int[10];
int posicionMayor = 0;
int mayor = int.MinValue;

for (int i = 0; i < 10; i++) {
    Console.Write("Ingrese un numero entero: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] > mayor) {
        mayor = numeros[i];
        posicionMayor = i;
    }
}

Console.WriteLine("El numero mayor es " + mayor + " y se encuentra en la posicion " + (posicionMayor + 1) + " del arreglo.");
