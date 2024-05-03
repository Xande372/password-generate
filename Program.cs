using System.Text;

Random random = new Random();

int rdn = random.Next(2);
int tamanhoSenha = (rdn == 0) ? 16 : 14;
string caixaCaracteres = "ABCDEFGHIJKLMNOPQRSTUVXYZ<>:?!@#$%&*()_+{}";
StringBuilder senha = new StringBuilder();

for (int cont = 0; cont < tamanhoSenha; cont++)
{
    int indiceCaixa = random.Next(0, caixaCaracteres.Length - 1);
    senha.Append(caixaCaracteres[indiceCaixa]);
}

Console.WriteLine("Senha gerada:");
Console.WriteLine(senha.ToString());