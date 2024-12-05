using RestSharp;

namespace CW1_Web_Browser
{
    public class HttpService    
    {
        // Asynchronously fetches HTML content from the specified URL
        public static async Task<RestResponse> FetchHtmlContentAsync(string url)
        {
            // Checks if the url starts with "http://" or "https://"
            // If it does not then prepend it to the start of the url
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }
            try
            {
                // Create a new RestClient instance with the specified url
                var client = new RestClient(url);

                // Create a RestRequest for the HTTP GET method 
                var request = new RestRequest();

                // Execute the request asynchronouslt and return the response
                return await client.ExecuteAsync(request);
            }
            // Throw an exception id any errors occur during the request
            catch (Exception ex)
            {
                throw new Exception($"Error fetching the HTML: {ex.Message}");
            }
        }
    }
}