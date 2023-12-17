namespace NetworkClient.Rest.Request
{
    public class RequestResponse<T>
    {
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}