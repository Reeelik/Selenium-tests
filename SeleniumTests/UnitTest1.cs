using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests {
    public class Tests {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Setup() {
            driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void Cleanup() {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void WejscieNaStrone() {
            String strUrl = driver.Url;
            String url = "http://localhost:5062/";
            Assert.AreEqual(url, strUrl);
        }

        [Test]
        public void StronaGlowna_Tekst() {
            IWebElement textElement = driver.FindElement(By.XPath("//ul/li[1]"));
            Assert.IsTrue(textElement.Displayed);
        }

        [Test]
        public void IdzDo_Mapa() {
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[2]"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Home/Privacy";
            Assert.AreEqual(actualUrl, strUrl);
        }

        [Test]
        public void IdzDo_StronaLogowania() {
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[3]"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Login";
            Assert.AreEqual(actualUrl, strUrl);
        }

        [Test]
        public void IdzDo_Formularz() {
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[4]"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Formularz";
            Assert.AreEqual(actualUrl, strUrl);
        }

        [Test]
        public void PrzejsciePoStronach() {
            //Mapa
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[2]"));
            button.Click();
            //Logowanie
            IWebElement button2 = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[3]"));
            button2.Click();
            //Formularz
            IWebElement button3 = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[4]"));
            button3.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Formularz";
            Assert.AreEqual(actualUrl, strUrl);
        }

        [Test]
        public void PoprawneLogowanie() {
            driver.FindElement(By.XPath("//ul/li[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='login']")).SendKeys("admin");
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("admin");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//div[3]/input"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//div[2]/div"));
            Assert.IsTrue(button2.Text.Contains("Witaj, admin"));
        }

        [Test]
        public void NiepoprawneLogowanie() {
            driver.FindElement(By.XPath("//ul/li[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='login']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("a");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//div[3]/input"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//div[2]/div"));
            Assert.IsTrue(button2.Text.Contains("B³êdne dane logowania. Spróbuj ponownie."));
        }

        [Test]
        public void PoprawneWypelnienieFormularza() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123456789");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsTrue(button2.Text.Contains("Wype³nij dane"));
        }

        [Test]
        public void NiepoprawnyFormularz_Pusty() {
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//ul/li[4]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        [Test]
        public void NiepoprawnyFormularz_Email() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123456789");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        [Test]
        public void NiepoprawnyFormularz_Telefon() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        [Test]
        public void NiepoprawnyFormularz_Telefon_Email() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        [Test]
        public void NiepoprawnyFormularz_Imie() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123123123");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        [Test]
        public void NiepoprawnyFormularz_Nazwisko() {
            driver.FindElement(By.XPath("//ul/li[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("");
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123123123");
            IWebElement button = WaitUntilElementIsVisible(driver, By.XPath("//form/div[5]"));
            button.Click();
            IWebElement button2 = driver.FindElement(By.XPath("//form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
        }

        private IWebElement WaitUntilElementIsVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10) {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(driver => {
                try {
                    var element = driver.FindElement(locator);
                    if (element.Displayed)
                        return element;
                    return null;
                }
                catch (NoSuchElementException) {
                    return null;
                }
                catch (StaleElementReferenceException) {
                    return null;
                }
            });
        }
    }
}