namespace TypedClient.Services;

public interface ICepService
{
  public Task<object> GetCep(string cep);
}
