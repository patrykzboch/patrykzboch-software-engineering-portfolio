using AngleSharp.Dom;
using CW1_Web_Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace functionalityTests.Tests.Tests
{
    public class DummyWebBrowser : CW1_Web_Browser.WebBrowser
    {
        public DummyWebBrowser() : base()
        {
            // Initialize anything if necessary
        }

        // You might want to override methods or properties if needed for testing
    }
    public class FavouritesFunctionalityTests
    {

        private readonly HttpService _httpService;
        private string testFilePath;

        public FavouritesFunctionalityTests()
        {
            _httpService = new HttpService();
            testFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "userFavouritesTests.txt");

        }

        [Fact]

        public async Task ValidateURL_ShouldReturnFalse_WhenUrlIsEmpty()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            var _favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);
            string emptyUrl = "";

            // Act
            bool result = await FavouritesFunctionality.ValidateURL(emptyUrl);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task ValidateURL_ShouldReturnFalse_invalidURL()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            string invalidUrl = "refd";
            var _favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);


            // Act
            bool result = await FavouritesFunctionality.ValidateURL(invalidUrl);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public async Task AddFavourite_ShouldAddFavourite_WhenNameAndUrlAreValid()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            string name = "facebook";
            string validUrl = "https://www.facebook.com";
            var _favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);


            // Act
            bool result = await _favouritesFunctionality.AddFavourite(name, validUrl);

            // Assert
            Assert.True(result);
            Assert.Contains(name, _favouritesFunctionality.UserFavourites);

        }

        [Fact]
        public async Task AddFavourite_ShouldNotAddFavourite_WhenEmptyName()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            string emptyName = "";
            string validUrl = "www.facebook.com";
            var _favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);


            // Act
            bool result = await _favouritesFunctionality.AddFavourite(emptyName, validUrl);

            // Assert
            Assert.False(result);
            Assert.Empty(_favouritesFunctionality.UserFavourites);
        }

        [Fact]

        public void EditFavourite_ShouldRenameFavourite_WhenOldNameExists()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            string oldName = "Favourite1";
            string newName = "Favourite2";
            string url = "www.facebook.com";
            var _favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);

            _favouritesFunctionality.UserFavourites.Add(oldName, url);

            // Act
            bool result = _favouritesFunctionality.EditFavourite(oldName, newName);

            // Assert
            Assert.True(result);
            Assert.Contains(newName, _favouritesFunctionality.UserFavourites);
            Assert.DoesNotContain(oldName, _favouritesFunctionality.UserFavourites);
        }

        [Fact]
        public void RemoveFavourite_ShouldReturnTrue_WhenFavouriteExist()
        {
            // Arrange
            var browser = new DummyWebBrowser();
            var favouritesListPanel = new Panel();
            var favouritesFunctionality = new FavouritesFunctionality(_httpService, browser);
            string removeName = "facebook";
            string url = "www.facebook.com";

            // Add the favourite that we will remove later
            favouritesFunctionality.UserFavourites.Add(removeName, url);

            Button button = new()
            {
                Text = removeName,
                Tag = url
            };
            favouritesListPanel.Controls.Add(button);

            // Act
            bool result = favouritesFunctionality.RemoveFavourite(removeName, favouritesListPanel);

            // Assert
            Assert.True(result); // Should return true since the favourite exists
            Assert.False(favouritesFunctionality.UserFavourites.ContainsKey(removeName)); // Should not exist in the dictionary
            Assert.False(favouritesListPanel.Controls.Contains(button));
        }




    }


}