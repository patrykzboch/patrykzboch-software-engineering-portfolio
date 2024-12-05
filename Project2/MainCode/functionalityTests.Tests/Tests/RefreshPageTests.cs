using CW1_Web_Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser = CW1_Web_Browser.WebBrowser;
using Xunit;

namespace functionalityTests.Tests.Tests
{
    public class RefreshPageTests
    {
        [Fact]

        public async Task RefreshPageAsync_ShouldRefreshWithLastVisitedURL()
        {
            // Arrange
            var browser = new WebBrowser();
            browser.lastVisitedURL = "https://www.example.com";
            var refreshPage = new RefreshPage(browser);

            // Act
            await refreshPage.RefreshPageAsync();

            // Assert
            Assert.Equal("https://www.example.com", browser.lastVisitedURL);
            // Additional assertions can be added here to verify the outcome of the refresh, 
            // such as changes in the browser state if applicable.
        }
    }
}
