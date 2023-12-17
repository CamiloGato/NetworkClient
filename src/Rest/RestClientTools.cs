using System;

namespace NetworkClient.Rest
{
    public static partial class RestClient
    {
        private static Uri UriBuilder(string url)
        {
            bool result = Uri.TryCreate(url, UriKind.Absolute, out var uriResult) 
                          && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (!result)
            {
                throw new ArgumentException("URL is not valid");
            }

            return uriResult;
        }
    }
}