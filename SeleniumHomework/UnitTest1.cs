using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace labatests
{

    public class Tests
    {
        private IWebDriver driver;
        private readonly By _LoginInputButton = By.XPath("//input[@name='txtUsername']");
        private const string _login = "Admin";
        private readonly By _PasswordInputButton = By.XPath("//input[@name='txtPassword']");
        private const string _password = "admin123";
        private readonly By _enterButton = By.XPath("//input[@name='Submit']");
        private readonly By _adminButton = By.XPath("//b[text()='Admin']");
        private readonly By _addButton = By.XPath("//input[@name='btnAdd']");
        private readonly By _addNameButton = By.XPath("//input[@name='systemUser[employeeName][empName]']");
        private const string _name = "Admin A";
        private readonly By _addUsername = By.XPath("//input[@name='systemUser[userName]']");
        private const string _username = "Andrii Melenchuk12";
        private readonly By _addPasswordButton = By.XPath("//input[@name='systemUser[password]']");
        private const string  _apassword = "andre2002_";
        private readonly By _addConfirmPasswordButton = By.XPath("//input[@name='systemUser[confirmPassword]']");
        private const string  _ComfirmPassword = "andre2002_";
        private readonly By _saveNewUser = By.XPath("//input[@name='btnSave']");
        private readonly By _searchUser = By.XPath("//input[@name='searchSystemUser[userName]']");
        private const string _newUser = "Andrii Melenchuk12";
        //private readonly By _userType = By.XPath("//select[@name='searchSystemUser[userType]']");
        private readonly By _takeType = By.XPath("//option[text()='ESS']");
        private readonly By _employeeNameTake = By.XPath("//input[@name='searchSystemUser[employeeName][empName]']");
        private readonly By _takeStatus = By.XPath("//option[text()='Enabled']");
        private readonly By _searchUserButton = By.XPath("//input[@name='_search']");
        private readonly By _resetButton = By.XPath("//input[@name='_reset']");
        private readonly By _searchMyUsername = By.XPath("//*[text()='Andrii Melenchuk12']");
        private readonly By _returnToAdminButton = By.XPath("//b[text()='Admin']");
        private readonly By _deleteUser = By.XPath("//tr//td//a[text()='Andrii Melenchuk12']//..//..//td//input");
        private readonly By _deleteButton = By.XPath("//input[@name='btnDelete']");
        private readonly By _confirmDeleteUser = By.XPath("//*[@id='dialogDeleteBtn']");
        
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
       
            var login = driver.FindElement(_LoginInputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_PasswordInputButton);
            password.SendKeys(_password);

            var enter = driver.FindElement(_enterButton);
            enter.Click();

            var admin = driver.FindElement(_adminButton);
            admin.Click();

            var add = driver.FindElement(_addButton);
            add.Click();

            var addName = driver.FindElement(_addNameButton);
            addName.SendKeys(_name);

            var addUsername = driver.FindElement(_addUsername);
            addUsername.SendKeys(_username);

            var addPassword = driver.FindElement(_addPasswordButton);
            addPassword.SendKeys(_apassword);

            var addComfirmPassword = driver.FindElement(_addConfirmPasswordButton);
            addComfirmPassword.SendKeys(_ComfirmPassword);

            Thread.Sleep(1000);

            var saveNewUser = driver.FindElement(_saveNewUser);
            saveNewUser.Click();

            Thread.Sleep(1000);

            var searchUser = driver.FindElement(_searchUser);
            searchUser.SendKeys(_newUser);

           // var userType = driver.FindElement(_userType);
           // userType.Click();

            var takeType = driver.FindElement(_takeType);
            takeType.Click();

            var _employeeName = driver.FindElement(_employeeNameTake);
            _employeeName.SendKeys(_name);

            var takeStatus = driver.FindElement(_takeStatus);
            takeStatus.Click();

            var searchUserButton = driver.FindElement(_searchUserButton);
            searchUserButton.Click();

            var resetButton = driver.FindElement(_resetButton);
            resetButton.Click();

            var searchMyUsername = driver.FindElement(_searchMyUsername);
            searchMyUsername.Click();

            var returnToAdmin = driver.FindElement(_returnToAdminButton);
            returnToAdmin.Click();

            var deleteUser = driver.FindElement (_deleteUser);
            deleteUser.Click();

            var deleteButton = driver.FindElement(_deleteButton);
            deleteButton.Click();

            var confirmDeleteUser = driver.FindElement(_confirmDeleteUser);
            confirmDeleteUser.Click();

            Thread.Sleep(2000);

            Assert.IsEmpty(driver.FindElements(By.XPath("//tr//td//a[text()='Andrii Melenchuk12']//..//..//td//input")));
        }
        public void TearDown()
        { 
        
        
        }
    }
}