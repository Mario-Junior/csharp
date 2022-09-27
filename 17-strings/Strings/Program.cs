// string.Concat()
string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";

string concatResult = string.Concat(textOne, textTwo, textThree);
Console.WriteLine(concatResult);


// string.Split()
string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";

string[] arrayEmails = emails.Split(";");
foreach (var email in arrayEmails)
{
  Console.WriteLine(email);
}


// string.IndexOf()
string trybe = "Trybe";
int index1 = trybe.IndexOf("y"); // Saída: 2. Pois, contanto que o index inicie em 0
Console.WriteLine("O índice é: " + index1);

int index2 = trybe.IndexOf("s"); // Saída: -1. Pois, o caracter 's' não existe na string
Console.WriteLine("O índice é: " + index2);

string trybeLove = "I love Trybe";
int index3 = trybeLove.IndexOf("e", 6); // Saída: 11. Pois, começa a busca a partir do index 6 e encontra o 'e' na palavra 'Trybe'
Console.WriteLine("O índice é: " + index3);

// DESCOMENTAR para verificar o erro!
// int index4 = trybe.IndexOf("e", 13); // Saída: Exception - ArgumentOutOfRangeException.
// // Pois, o tamanho da string buscada é 12 e foi pedido para a função IndexOf() buscar um index a partir de 13; sendo assim, a exceção foi lançada.
// Console.WriteLine("O índice é: " + index4);


// string.Contains() => ATENÇÃO: É case sensitive!
List<string> languages = new List<string> 
{
 "c#",
 "java",
 "javascript",
 "python"
};

Console.WriteLine("Entre sua linguagem para busca aqui: ");
string? languageSearch = Console.ReadLine();

bool languageExists = languages.Contains(languageSearch);

if (languageExists) 
{
  Console.WriteLine("Essa linguagem existe no sistema");
}
else 
{
  Console.WriteLine("Essa linguagem não existe no sistema");
}


// string.Join()
// Exemplo: criação da enumeração dos números inteiros entre 1 e 10
IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
Console.WriteLine(listNumbers); // Saída = System.Linq.Enumerable+RangeIterator

string numbersText = string.Join(',', listNumbers); // ',' é do tipo 'char' e só aceita UM caracter entre as ''
Console.WriteLine(numbersText); // Saída = 1,2,3,4,5,6,7,8,9,10


// Interpolação de strings
string text1 = "Isso é uma string";

string textString = "string";
string text2 = $"Isso é uma {textString}";

Console.WriteLine("Por favor, insira seu nome: ");
string name = Console.ReadLine();
string subject = $"Olá, {name}! Boas vindas ao sistema parceiro da Trybe!";
Console.WriteLine(subject);

string text3 = "Eu aprendi a lidar com as propriedades e funções da classe String na Trybe!";
int index = text3.IndexOf("p", 20);
Console.WriteLine(index);  
