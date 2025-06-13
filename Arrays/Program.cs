
//Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 80;
arrayInteiros[2] = 64;

//Redimensionando um array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Copiando array para outro

int[] arrayNovo = new int[arrayInteiros.Length * 2];

Array.Copy(arrayInteiros, arrayNovo, arrayInteiros.Length);

for (int i = 0; i < arrayInteiros.Length; i++)
{
  Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine("Percorrendo com FOREACH");

//Percorrendo o array com ForEach
//Para cada valor em Array faça..
foreach (int valor in arrayInteiros)
{
  Console.WriteLine(valor);
}


//Listas

List<String> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
  Console.WriteLine($"Posição N°: {i} - {listaString[i]}");
}

Console.WriteLine("Percorrendo com ForEach");

int ii = 0;
foreach (string item in listaString)
{
  Console.WriteLine($"Posição N°: {ii} - {listaString[ii]}");
  ii++;
}