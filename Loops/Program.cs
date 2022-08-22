// Instrução while
int count = 0;
while (count < 10)
{
  Console.WriteLine("Count " + count);
  count++;
}

Console.WriteLine("**********************************");
// Instrução do/while

int counter = 0;
do
{
  Console.WriteLine("Count" + counter);
  counter++;
}
while (counter < 10);

Console.WriteLine("**********************************");
// Instrução for

for (int index = 0; index < 3; index++)
{
  Console.WriteLine("Número: " + index);
}

Console.WriteLine("**********************************");
// Instrução foreach

string[] avengers = new string[] {"Black Widow", "Hulk", "Iron Man"};
foreach (var avenger in avengers)
{
  Console.WriteLine(avenger);
}

Console.WriteLine("**********************************");
// Instruções de uma única linha
// No C#, um bloco de instrução é sempre escrito entre chaves {} para delimitar seu contexto.
// Porém, o uso das chaves não é obrigatório para definir uma instrução de uma linha, exemplos:
for (int count2 = 0; count2 < 10; count2++) Console.WriteLine(count2);
Console.WriteLine("**********************************");
int[] numbers = new int[] { 1, 2, 3, 4 };
var sum = 0;
foreach (var number in numbers) sum += number;
Console.WriteLine("Sum = " + sum);
Console.WriteLine("**********************************");
var isClosed = false;
while (!isClosed) isClosed = true;
Console.WriteLine("Is Closed? R: " + isClosed);

Console.WriteLine("**********************************");
// Instrução break

string[] teachers = new string[] { "Joel", "Marilene", "Tess" };
string[] students = new string[] { "Abby", "Ellie", "Joel" };

foreach (var teacher in teachers)
{
  Console.WriteLine("Teacher: " + teacher + ". Student:");
  foreach (var student in students)
  {
    if (teacher == student)
      break;
      Console.WriteLine(student);
  }
}

Console.WriteLine("**********************************");
// Instrução continue

int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2 };
var countVotes = 0;

foreach (var vote in votes)
{
  if (vote > 3)
    continue;
    countVotes++;
}
Console.WriteLine(countVotes + " votos válidos");
