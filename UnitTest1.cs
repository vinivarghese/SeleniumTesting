using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestingTradeMe
{
    [TestClass]
    public class TestTradeMe
    {
        //Initializing a variable to control the web browser - Google Chrome
        readonly IWebDriver driver = new ChromeDriver(@"/Users/vinivarghese/.nuget/packages/selenium.webdriver.chromedriver/74.0.3729.6/driver/mac64");

        [TestMethod]
        //A test case to check the working of Login and Log Out of the application
        public void TestLogInAndLogOut()
        {
            //View broser on full screen
            driver.Manage().Window.FullScreen();

            //User logs in to Trade Me
            //Open link to Trade Me
            driver.Navigate().GoToUrl("https://www.trademe.co.nz/");

            //Click on the login button
            driver.FindElement(By.Id("LoginLink")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Enter user credentials to login to Trade Me
            //Enter credentials for User Id
            driver.FindElement(By.CssSelector("#page_email")).SendKeys("vini.varghese91@gmail.com");
            //Enter credentials for Password
            driver.FindElement(By.CssSelector("#page_password")).SendKeys("ABCD12345");
            //Click on login button
            driver.FindElement(By.Id("LoginPageButton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Click on Log Out to go out of Trade Me
            //Click on log out button
            driver.FindElement(By.ClassName("btn-psuedo-link")).Click();

            //Disposing the browser variable
            driver.Dispose();
        }

        [TestMethod]
        public void TestAddViewRemoveVehicleFromWatchList()
        {
            //View broser on full screen
            driver.Manage().Window.FullScreen();

            //User logs in to Trade Me
            //Open link to Trade Me
            driver.Navigate().GoToUrl("https://www.trademe.co.nz/");

            //Click on the login button
            driver.FindElement(By.Id("LoginLink")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Enter user credentials to login to Trade Me
            //Enter credentials for User Id
            driver.FindElement(By.CssSelector("#page_email")).SendKeys("vini.varghese91@gmail.com");
            //Enter credentials for Password
            driver.FindElement(By.CssSelector("#page_password")).SendKeys("ABCD12345");
            //Click on login button
            driver.FindElement(By.Id("LoginPageButton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Click on Motors Tab
            driver.FindElement(By.XPath("//*[@id=\"SearchTabs1_MotorsLink\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Click to view only Electric Cars
            driver.FindElement(By.XPath("//*[@id=\"SiteHeader_SideBar_MotorsSidebarSearch_searchTabs\"]/ul/li[2]/a")).Click();

            //Click to view options for Make Type available in Drop Down
            var makeType = driver.FindElement(By.XPath("//*[@id=\"14_chosen\"]/a/span"));
            makeType.Click();
            Thread.Sleep(1000);

            //Select value for Make Type from listed options
            var selectedMakeType = driver.FindElement(By.XPath("//*[@id=\"14_chosen\"]/div/ul/li[5]"));
            selectedMakeType.Click();

            //Click to view options for Body Style available in Combo boxes
            var bodyStyle = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[3]/p/span"));
            bodyStyle.Click();
            Thread.Sleep(1000);

            //Select value for Body Style from listed options
            var selectedBodyStyle = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[3]/div/ul/li[4]/label"));
            selectedBodyStyle.Click();
            bodyStyle.Click();
            Thread.Sleep(1000);

            //Click to view options for Electric Type available in Drop Down
            var electricType = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[4]/p/span"));
            electricType.Click();
            Thread.Sleep(1000);

            //Select value for Electric Type from listed options
            var selectedElectricType = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[4]/div/ul/li[3]/label"));
            selectedElectricType.Click();
            Thread.Sleep(1000);

            //Click to view options for From Distance available in Drop Down
            var fromDistance = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[6]/div[1]/p/span"));
            fromDistance.Click();
            Thread.Sleep(1000);

            //Select value for From Distance from listed options
            var selectedFromDistance = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[6]/div[1]/div/ul/li[1]/label"));
            selectedFromDistance.Click();
            Thread.Sleep(1000);

            //Click to view options for To Distance available in Drop Down
            var toDistance = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[6]/div[2]/p/span"));
            toDistance.Click();
            Thread.Sleep(1000);

            //Select value for To Distance from listed options
            var selectedToDistance = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[6]/div[2]/div/ul/li[2]/label"));
            selectedToDistance.Click();
            Thread.Sleep(1000);

            //Click to view options for From Year available in Drop Down
            var fromYear = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[7]/div[1]/p/span"));
            fromYear.Click();
            Thread.Sleep(1000);

            //Select value for From Year from listed options
            var selectedFromYear = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[7]/div[1]/div/ul/li[4]"));
            selectedFromYear.Click();
            Thread.Sleep(1000);

            //Click to view options for To Year available in Drop Down
            var toYear = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[7]/div[2]/p/span"));
            toYear.Click();
            Thread.Sleep(1000);

            //Select value for To Year from listed options
            var selectedToYear = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[7]/div[2]/div/ul/li[2]/label"));
            selectedToYear.Click();
            Thread.Sleep(1000);

            //Click to view options for regions available in Drop Down
            var region = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[9]/p/span"));
            region.Click();
            Thread.Sleep(1000);

            //Select value for To Year from listed options
            var selectedRegion = driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/div[9]/div/ul/li[8]/label"));
            selectedRegion.Click();
            Thread.Sleep(1000);

            //Click on Search button to view the results
            driver.FindElement(By.XPath("//*[@id=\"sidebarSearch_electriccars\"]/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Click on vehicle to view all its features
            driver.FindElement(By.XPath("//*[@id=\"ListViewList\"]/li[1]/div[1]/div[2]/a/div[2]/div[1]")).Click();
            Thread.Sleep(1000);

            //Add vehicle to watch list
            driver.FindElement(By.XPath("//*[@id=\"Watchlist_SaveToWatchlistButton\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //View items in watch list
            //Click on watch list button to open dropdown consisting of items added to watch list
            driver.FindElement(By.XPath("//*[@id=\"SiteHeader_SiteTabs_BarOfSearch_watchlistDropdownOpen\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //View complete list of items added to watch list
            driver.FindElement(By.XPath("//*[@id=\"viewWatchlistDropDownLink\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Select item to remove from watch list
            driver.FindElement(By.XPath("//*[@id=\"0\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Click on delete button to remove selected item
            driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/div[4]/form/table[4]/tbody/tr/td[1]/input[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//*[@id=\"submit1\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Go to home page
            driver.FindElement(By.XPath("//*[@id=\"SiteHeader_SiteTabs_kevin\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Click on Log Out to go out of Trade Me
            //Click on log out button
            driver.FindElement(By.ClassName("btn-psuedo-link")).Click();

            //Disposing the browser variable
            driver.Dispose();
        }

        [TestMethod]
        public void TestAddViewRemoveBookFromCart()
        {
            //View broser on full screen
            driver.Manage().Window.FullScreen();

            //User logs in to Trade Me
            //Open link to Trade Me
            driver.Navigate().GoToUrl("https://www.trademe.co.nz/");

            //Click on the login button
            driver.FindElement(By.Id("LoginLink")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Enter user credentials to login to Trade Me
            //Enter credentials for User Id
            driver.FindElement(By.CssSelector("#page_email")).SendKeys("vini.varghese91@gmail.com");
            //Enter credentials for Password
            driver.FindElement(By.CssSelector("#page_password")).SendKeys("ABCD12345");
            //Click on login button
            driver.FindElement(By.Id("LoginPageButton")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Search for Book
            //Search for book by name
            driver.FindElement(By.XPath("//*[@id=\"searchString\"]")).SendKeys("Saturday Requiem");
            //Click on find to search for book
            driver.FindElement(By.XPath("//*[@id=\"generalSearch\"]/div[2]/button/span")).Click();
            //Click on book to view all the features
            driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/div[9]/div/a[1]/div/div[2]")).Click();

            //Add book to cart
            //Click on 'Add Cart' to add book to the cart
            driver.FindElement(By.XPath("//*[@id=\"addToCartText\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Click on 'Go to Cart' to view items on cart
            driver.FindElement(By.XPath("//*[@id=\"ShoppingCartPopup_GoToCartInnerSpan\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Proceed to payment
            //Click on 'Proceed to checkout
            driver.FindElement(By.XPath("//*[@id=\"Checkout\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Select physical address for home delivery 
            driver.FindElement(By.XPath("//*[@id=\"delivery-options\"]/li/span/span/label")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Click on 'Confirm purchase' to confirm purchase
            driver.FindElement(By.XPath("//*[@id=\"submitForm\"]")).Click();

            //Go to home page
            driver.FindElement(By.XPath("//*[@id=\"SiteHeader_SiteTabs_kevin\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Remove items from cart
            //Click on 'Cart' to view items in cart
            driver.FindElement(By.XPath("//*[@id=\"cart-button\"]")).Click();
            //Click on 'Remove' to remove item from cart
            driver.FindElement(By.XPath("//*[@id=\"shopping-cart\"]/div[2]/div/div[3]/div[1]/div/div[1]/div/ul/li[2]/div[1]/div[2]/div/a/div/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Go to home page
            driver.FindElement(By.XPath("//*[@id=\"SiteHeader_SiteTabs_kevin\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Click on Log Out to go out of Trade Me
            //Click on log out button
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div[1]/div[1]/div[3]/div/form/p/input[2]")).Click();

            //Disposing the browser variable
            driver.Dispose();
        }
    }
}
