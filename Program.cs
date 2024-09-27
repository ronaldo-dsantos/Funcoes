// ***** Funções *****

ChamarFuncoes();

string NomeCompleto() // string para informar que a função vai retornar uma string
{
  string primeiroNome = "Ronaldo";
  string segundoNome = "Domingues";

  return primeiroNome + " " + segundoNome;
}

int SomaValores() // int para informar que a função vai retornar um inteiro
{
  return 8 + 2;
}

void ChamarFuncoes() // void para informar que a função não tem retorno (vazia), apenas executa as intruções que constam nela 
{
  var nomeCompleto = NomeCompleto();
  var somaValores = SomaValores();

  Console.WriteLine(nomeCompleto);
  Console.WriteLine(somaValores);
}

var somarValores = SomarValores(3, 5); // Chamando a função passando valores por parametro
Console.WriteLine(somarValores);

var nomeIdade = NomeIdade("Ronaldo", 38);
Console.WriteLine(nomeIdade);

int SomarValores(int a, int b) // Função recebendo valores por parametro
{
  return a + b;
}

string NomeIdade(string nome, int idade){
  return "Meu nome é " + nome + " e tenho " + idade + " anos.";
}
