using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        public int num;

        public LoginSteps()
        {
            // Ініціалізуємо драйвер у конструкторі
            driver = new ChromeDriver(); // Ви можете вибрати інший драйвер за потребою
            loginPage = new LoginPage(driver);
            num = 0;
        }

        [Given(@"I am on the banking website")]
        public void GivenIAmOnTheBankingWebsite()
        {
            loginPage.OpenLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject"); // Замініть URL на реальний URL вашого веб-сайту
        }

        [When(@"I select ""Login as Bank Manager"" option")]
        public void WhenISelectLoginAsBankManagerOption()
        {
            loginPage.ClickLoginAsBankManager();
        }

        [Then(@"I click ""Open Account""")]
        public void OpenAccount()
        {
            loginPage.clickOpenAccount();
        }

        [Then(@"I choose Customer and Currency")]
        public void ChooseCustomerAndCurrency()
        {
            loginPage.chooseCustomerAndCurrency("Harry Potter", "Rupee");
        }

        [When(@"I click button Process")]
        public void Clickprocess()
        {
            loginPage.process();
        }

        [Then(@"I should see alert about opening account")]
        public void ClickOKAlert()
        {
            loginPage.clickOk();
        }

        [Then(@"I click ""Customers""")]
        public void ClickCustomers() {
            loginPage.ClickCustomers();
        }

        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            loginPage.CloseDriver();
        }
    }
}
