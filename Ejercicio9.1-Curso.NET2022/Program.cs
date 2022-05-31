/*
1) Pedir al usuario la longitud de un vector
2) Crear el vector del tamaño ingresado.
3) Llenar el mismo con datos aleatorios
4) Mostrar el vector por pantalla

5) Invertir el vector, de manera que el primer elemento quede al último
y el útimo en el primero; el segundo en anteúltimo, 
el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector
es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, 
el vector debe quedar así: 50, 40, 30, 20, 10.  

Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# 
para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar 
para realizar el ejercicio. 

6) Mostrar el vector nuevamente.
*/

//Ingreso longitud del vector
Console.WriteLine("Ingrese longitud del vector = ");
int longitudVector = int.Parse(Console.ReadLine());
Console.WriteLine("=======================================");

//Creacion del vector
int[] vectorAleatorio = new int[longitudVector];

//Ingreso numeros aleatorios dentro del vector
Random numeroAleatorio = new Random();

Console.WriteLine($"Vector aleatorio de longitud igual a {longitudVector}");
Console.WriteLine("=======================================");
for (int i = 0; i < vectorAleatorio.Length; i++)
{
    vectorAleatorio[i] = numeroAleatorio.Next(0, 10);
    Console.WriteLine(vectorAleatorio[i]);
}

Console.WriteLine("=======================================");
Console.WriteLine("Inversion del vector aleatorio");
Console.WriteLine("=======================================");

for (int i = vectorAleatorio.Length - 1; i >= 0 ; i--)
{
    Console.WriteLine(vectorAleatorio[i]);
}



