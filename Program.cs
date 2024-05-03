using System.Text;

// quantidade de caracteres + possíveis caracteres;
int qtd = 20;
string possiveisCaracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                             "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower() +
                             "0123456789" + "!@#$%&*";

// sorteio dos possiveis caracteres;
Random sorteio = new Random();
int numeroSorteado = 0;

// armazenar o sorteio
StringBuilder senha = new StringBuilder();

// loop
for (int x = 0; x < qtd; x++)
{
    numeroSorteado = sorteio.Next(0, possiveisCaracteres.Length - 1);
    senha.Append(possiveisCaracteres[numeroSorteado]);
}

Console.WriteLine("Senha gerada:");
Console.WriteLine(senha.ToString());