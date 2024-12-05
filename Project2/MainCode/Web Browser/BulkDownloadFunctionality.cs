namespace CW1_Web_Browser
{
    public class BulkDownloadFunctionality
    {

        // Method to perform a bulk download of web page urls
        public static async void BulkDownload(string filename, RichTextBox searchBox, RichTextBox htmlContentBox, Panel downloadPanel, Label statusCode, Label title)
        {
            // Get the full file path in the user's Documents folder
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filename);

            // Check if the file exists before proceeding with the download
            if (File.Exists(filePath))
            {
                // Clear the html content and the search box
                // Hide the title,code and the download panel
                htmlContentBox.Text = string.Empty;
                searchBox.Text = string.Empty;
                downloadPanel.Visible = false;
                statusCode.Visible = false;
                title.Visible = false;

                // Open the file containing URLs and start reading line by line
                using StreamReader reader = new(filePath);
                string url;

                // Loop through each URL in the file until the end of the file
                while ((url = reader.ReadLine()) != null)
                {
                    // Get the HTTP repsonse from the url read
                    var response = await HttpService.FetchHtmlContentAsync(url);

                    // Get the byte count of the response
                    long byteCount = response.RawBytes?.Length ?? 0;

                    // Add the download result to the HTML content box in the format
                    // <StatusCode> <ByteCount> <URL>
                    htmlContentBox.Text += $"{(int)response.StatusCode} {byteCount} {url}\n";
                }

            }
        }
    }
}
