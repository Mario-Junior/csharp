// Entrada de dados
Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada(s)'!");
Console.WriteLine("Informe o nome do cômodo: ");
string room = Console.ReadLine();

Console.WriteLine("Informe, em metros, a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe, em metros, o comprimento deste cômodo: ");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potência, em watts, da(s) lâmpada(s) que será(ão) utilizada(s): ");
int power = int.Parse(Console.ReadLine());

// Processamento
decimal roomSquareMeter = width * length;
decimal quotientX = power / 18M;
decimal totalLampsNeeded = roomSquareMeter / quotientX;

// Saída de dados
Console.WriteLine("Para iluminar o cômodo: " + room + " com " + roomSquareMeter.ToString("N2") + "m² " + "será necessária a instalação de " + totalLampsNeeded.ToString("N2") + " lâmpada(s)");
