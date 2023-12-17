using System;
using System.Threading.Tasks;
using NetworkClient.Rest.Request;

namespace NetworkClient.Rest
{
    public partial class RestClient
    {
        private static Task<RequestResponse<T>> ExecuteRequestAsync<T>(string url,
            Func<Uri, Task<RequestResponse<T>>> action)
        {
            Uri uri = UriBuilder(url);
            return action(uri);
        }
        
        public static Task<RequestResponse<string>> GetAsync(string url)
        {
            return ExecuteRequestAsync(url, _client.GetRequest<string>);
        }

        public static Task<RequestResponse<T>> GetAsync<T>(string url)
        {
            return ExecuteRequestAsync(url, _client.GetRequest<T>);
        }

        public static Task<RequestResponse<string>> PostAsync(string url)
        {
            return ExecuteRequestAsync(url, _client.PostRequest<string>);
        }
        
        public static Task<RequestResponse<T>> PostAsync<T>(string url)
        {
            return ExecuteRequestAsync(url, _client.PostRequest<T>);
        }
        
        public static Task<RequestResponse<string>> PutAsync(string url)
        {
            return ExecuteRequestAsync(url, _client.PutRequest<string>);
        }
        
        public static Task<RequestResponse<T>> PutAsync<T>(string url)
        {
            return ExecuteRequestAsync(url, _client.PutRequest<T>);
        }
        
        public static Task<RequestResponse<string>> DeleteAsync(string url)
        {
            return ExecuteRequestAsync(url, _client.DeleteRequest<string>);
        }
        
        public static Task<RequestResponse<T>> DeleteAsync<T>(string url)
        {
            return ExecuteRequestAsync(url, _client.DeleteRequest<T>);
        }
    }
}