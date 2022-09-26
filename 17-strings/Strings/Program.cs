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

int index4 = trybe.IndexOf("e", 13); // Saída: Exception - ArgumentOutOfRangeException.
// Pois, o tamanho da string buscada é 12 e foi pedido para a função IndexOf() buscar um index a partir de 13; sendo assim, a exceção foi lançada.
Console.WriteLine("O índice é: " + index4);
