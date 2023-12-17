using System.Collections.Generic;
using NetworkClient.Rest.Client;

namespace NetworkClient.Rest
{
    public static partial class RestClient
    {
        private static IRestClient _client;
        private static IDictionary<string, string> _headers;
        
        public static void Initialize(IRestClient client, IDictionary<string, string> headers)
        {
            _client = client;
            _headers = headers;
        }
    }
}