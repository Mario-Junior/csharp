namespace DateHandler;

public class Schedule : IScheduleFormat
{
    public DateTime[] nextEvents { get; }

    public Schedule()
    {
        nextEvents = new DateTime[10];
    }

    public string NextEvent()
    {
        if(nextEvents[0] == new DateTime()) return "Não há eventos marcados";
        else return nextEvents[0].ToString("D");
    }

    public void AddEventAtDays(int days)
    {        

    }

    public void RemoveFirstEvent()
    {

    }
}
