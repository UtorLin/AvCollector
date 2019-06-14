using System.Threading.Tasks;
using RestSharp;

namespace Util.Helper
{
    public class RestSharpHelper
    {
        public static T Execute<T>(string baseUrl, string jsonContent)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json", jsonContent, ParameterType.RequestBody);
            var response = client.Execute(request);
            return JsonHelper.Deserialize<T>(response.Content);
        }

        public static async Task<T> ExcutePostAsync<T>(string baseUrl)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest();
            var restResponse = await client.ExecutePostTaskAsync(request);
            return JsonHelper.Deserialize<T>(restResponse.Content);
        }

        public static async Task<T> ExecutePostAsync<T>(string baseUrl, string jsonContent)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest();
            request.AddParameter("application/json", jsonContent, ParameterType.RequestBody);
            var postRequest = await client.ExecutePostTaskAsync(request);
            return JsonHelper.Deserialize<T>(postRequest.Content);
        }

        public static async Task<T> ExecuteGetAsync<T>(string baseUrl, string parameter)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            var getRequest = await client.ExecuteGetTaskAsync<T>(request);
            return JsonHelper.Deserialize<T>(getRequest.Content);
        }

    }
}