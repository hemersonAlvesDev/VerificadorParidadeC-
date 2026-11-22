using VerificadorParidade.App;

var verificador = new VerificadorParidadeClass();
Console.Write("Número inteiro: ");

int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(verificador.EhPar(numero) ? "Par" : "Ímpar");