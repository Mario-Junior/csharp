// Utilizando a struct SEM construtor (acesso aos atributos)
Time time;
time.hour = 10;
time.minute = 30;
time.second = 51;
time.shift = "PM";
Console.WriteLine("1. Horário: " + time.hour + ":" + time.minute + ":" + time.second + " " + time.shift);

// ---------------------------------------

// Inicializando uma struct com construtor (instanciação e acesso aos atributos e métodos)

Schedule now = new Schedule(10, 30, 51, "AM");
Console.WriteLine("2. Horário: " + now.GetSchedule());

// Atribuindo uma struct iniciada à uma nova struct
Schedule now2 = now;
Console.WriteLine("3. Horário: " + now2.GetSchedule());

// Criando uma struct SEM construtor
struct Time
{
  public int hour, minute, second;
  public string shift;
}

// Criando uma struct COM construtor
struct Schedule
{
  private int hour, minute, second;
  private string shift;

  // Constructor da struct
  public Schedule(int hour, int minute, int second, string shift)
  {
    this.hour = hour % 24;
    this.minute = minute % 60;
    this.second = second % 60;
    this.shift = shift;
  }

  // Método da struct
  public string GetSchedule()
  {
    return hour.ToString() + ":" + minute.ToString() + ":" + second.ToString() + " " + shift;
  }
}
