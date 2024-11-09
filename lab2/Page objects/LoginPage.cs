using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq.Expressions;
using System.Threading;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    // Метод для відкриття сторінки в браузері
    public void OpenLoginPage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    // Метод для вибору опції "Login as Bank Manager"
    public void ClickLoginAsBankManager()
    {
        // Знайдіть елемент кнопки "Bank Manager Login" за допомогою селектора і натисніть на неї
        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Bank Manager Login']")));
        loginButton.Click();
    }

    public void clickOpenAccount()
    {
        IWebElement openaccount = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Open Account')]")));
        openaccount.Click();
    }

    public void ClickCustomers()
    {
        IWebElement customers = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Customers')]")));
        customers.Click();
        Thread.Sleep(500);
    }

    public void chooseCustomerAndCurrency(string customername, string Currency)
    {
        //searchInput.Clear();
        Thread.Sleep(500);
        IWebElement customerName = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//select[@name='userSelect']")));
        customerName.SendKeys(customername);
        IWebElement currency= wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//select[@name='currency']")));
        currency.SendKeys(Currency);
    }

    public void process()
    {
        IWebElement process = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Process')]")));
        Thread.Sleep(1000);
        process.Click();
    }

    public void clickOk()
    {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
    }

    public void CloseDriver()
    {
        driver.Quit();
    }

}
