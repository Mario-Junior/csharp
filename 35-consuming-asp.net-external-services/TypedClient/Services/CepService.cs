namespace TypedClient.Services;

public class CepService : ICepService
{
  private readonly HttpClient _client;
  private const string _baseUrl = "https://viacep.com.br/ws/";

  public CepService(HttpClient client)
  {
    _client = client;
    _client.BaseAddress = new Uri(_baseUrl);
  }

  public async Task<object> GetCep(string cep)
  {
    // faço GET com o recurso que quero solicitar
    var response = await _client.GetAsync($"{cep}/json/");
    // valido o código de retorno
    if (!response.IsSuccessStatusCode)
    {
      // caso tenha dado erro, retorno um objeto vazio
      return default(Object)!;
    }
    // leio o retorno do corpo da mensagem
    var result = await response.Content.ReadFromJsonAsync<object>();

    // retorno o objeto
    return result!;
  }
}
