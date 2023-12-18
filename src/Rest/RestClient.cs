using NetworkClient.Rest.Client;
using NetworkClient.Rest.Request;

namespace NetworkClient.Rest
{
    public static partial class RestClient
    {
        private static IRestClient _client;
        private static RequestHeaders _headers;
        
        public static void Initialize(IRestClient client, RequestHeaders headers)
        {
            _client = client;
            _headers = headers;
        }
    }
}