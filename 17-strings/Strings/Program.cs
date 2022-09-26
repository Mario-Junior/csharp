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
