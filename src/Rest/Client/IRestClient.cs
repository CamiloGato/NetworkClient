using System;
using System.Threading.Tasks;
using NetworkClient.Rest.Request;

namespace NetworkClient.Rest.Client
{
    public interface IRestClient
    {
        Task<RequestResponse<T>> GetRequest<T>(Uri uri);
        Task<RequestResponse<T>> PostRequest<T>(Uri uri);
        Task<RequestResponse<T>> PutRequest<T>(Uri uri);
        Task<RequestResponse<T>> DeleteRequest<T>(Uri uri);
    }
}