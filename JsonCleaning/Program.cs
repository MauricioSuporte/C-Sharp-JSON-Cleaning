using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main()
    {
        var client = new HttpClient();
        var response = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/json-cleaning");
        var json = JObject.Parse(response);
        Limpar(json);
        Console.WriteLine(json);
    }

    private static void Limpar(JToken jToken)
    {
        if (jToken.Type == JTokenType.Object)
        {
            LimparObjeto(jToken);
        }
        else if (jToken.Type == JTokenType.Array)
        {
            LimparArray(jToken);
        }
    }

    private static void LimparObjeto(JToken jToken)
    {
        var propriedadesRemoviveis = new List<JProperty>();

        foreach (var propriedade in jToken.Children<JProperty>())
        {
            if (Invalido(propriedade.Value))
            {
                propriedadesRemoviveis.Add(propriedade);
            }
            else
            {
                Limpar(propriedade.Value);
            }
        }

        Remover(propriedadesRemoviveis);
    }

    private static void LimparArray(JToken jToken)
    {
        var itensRemoviveis = new List<JToken>();

        foreach (var item in jToken.Children())
        {
            if (Invalido(item))
            {
                itensRemoviveis.Add(item);
            }
            else
            {
                Limpar(item);
            }
        }

        Remover(itensRemoviveis);
    }

    private static bool Invalido(JToken token)
    {
        return string.IsNullOrEmpty(token.ToString()) ||
               token.ToString() == "N/A" ||
               token.ToString() == "-";
    }

    private static void Remover(IEnumerable<JToken> itens)
    {
        foreach (var item in itens)
        {
            item.Remove();
        }
    }
}