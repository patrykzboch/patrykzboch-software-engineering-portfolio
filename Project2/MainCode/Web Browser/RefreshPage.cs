using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_Web_Browser
{
    // Class responsible for refreshing the current web page in the web browser
    public class RefreshPage(WebBrowser webBrowser)
    {
        // Reference to the WebBrowser instance
        private readonly WebBrowser browser = webBrowser;

        // Asynchronous method to refresh the current page
        public async Task RefreshPageAsync() {

            // Fetch and display the last visited URL without adding it to the history
            await browser.FetchAndDisplayHttpResponse(browser.lastVisitedURL,false);
        }
        
    }
}
