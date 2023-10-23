
// -----> Código comentado: Inferior C# 12.O

//int[] numeros = new int[] { 1, 2, 3, 4, 5 };
int[] numeros = [1, 2, 3, 4, 5];

//int[] pares = new int[] { 2, 4, 6, 8, 10 };
//int[] impares = new int[] { 1, 3, 5, 7, 9 };
//int[][] numerosParesImpares = new int[][] { pares, impares };
int[] pares = [2, 4, 6, 8, 10];
int[] impares = [1, 3, 5, 7, 9];

int[][] numerosParesImpares = [pares, impares];

//Span<string> RegiaoSul = new string[] { "PR", "SC", "RS" };
Span<string> RegiaoSul = ["PR", "SC", "RS"];

//ReadOnlySpan<string> RegiaoSudeste = new string[] { "ES", "MG", "RJ", "SP" };
ReadOnlySpan<string> RegiaoSudeste = ["ES", "MG", "RJ", "SP"];

//List<int> lista1 = new List<int>() { 1, 2, 3 };
//List<int> lista2 = new List<int>() { 4, 5, 6 };

//List<int> listaCombinada = new List<int>();
//listaCombinada.AddRange(lista1);
//listaCombinada.AddRange(lista2);

List<int> lista1 = [1, 2, 3];
List<int> lista2 = [4, 5, 6];
List<int> listaCombinada = [.. lista1, .. lista2];