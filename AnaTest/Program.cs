Console.WriteLine("Qual Seu Nome?");
string meuNome = Console.ReadLine();

Console.WriteLine("Qual Sua data De Nascimento?");
DateTime minhaDataNascimento = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Voce E Formada?");
bool formada = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Qual Seu Numero Da Sorte?");
int numeroDaSorte = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Nome: " + meuNome);
Console.WriteLine("Idade: " + (DateTime.Now.Year - minhaDataNascimento.Year).ToString());
Console.WriteLine("Formada?: " + formada);
Console.WriteLine("Numero Da Sorte: " + numeroDaSorte);