using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumTests {
    public class Tests2 {
        public WebDriverWait wait;

        [Test]
        public void WejscieNaStrone() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            String strUrl = driver.Url;
            Assert.AreEqual(url, strUrl);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void StronaGlowna_Tekst() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/h1[1]"));
            button.Click();
            Assert.IsTrue(button.Text.Contains("Opis wybranych testów"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void IdzDo_Mapa() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Home/Privacy";
            Assert.AreEqual(actualUrl, strUrl);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void IdzDo_StronaLogowania() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Login";
            Assert.AreEqual(actualUrl, strUrl);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void IdzDo_Formularz() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a"));
            button.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Formularz";
            Assert.AreEqual(actualUrl, strUrl);
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void PrzejsciePoStronach() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            // Mapa
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
            button.Click();
            Thread.Sleep(1000);
            // Logowanie
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
            button2.Click();
            Thread.Sleep(1000);
            // Formularz
            IWebElement button3 = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a"));
            button3.Click();
            String strUrl = driver.Url;
            String actualUrl = "http://localhost:5062/Account/Formularz";
            Assert.AreEqual(actualUrl, strUrl);
            driver.Close();
            driver.Quit();
        }

        public void PoprawneLogowanie() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='login']")).SendKeys("admin");
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("admin");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[3]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div"));
            Assert.IsTrue(button2.Text.Contains("Witaj, admin"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawneLogowanie() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='login']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("a");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[3]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div"));
            Assert.IsTrue(button2.Text.Contains("B³êdne dane logowania. Spróbuj ponownie."));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void PoprawneWypelnienieFormularza() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123456789");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsTrue(button2.Text.Contains("Wype³nij dane"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawnyFormularz_Pusty() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawnyFormularz_Email() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123123123");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawnyFormularz_Telefon() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }


        [Test]
        public void NiepoprawnyFormularz_Telefon_Email() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']"));
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']"));
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawnyFormularz_Imie() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']"));
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123123123");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void NiepoprawnyFormularz_Nazwisko() {
            WebDriver driver = new ChromeDriver();
            String url = "http://localhost:5062/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[4]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='name']")).SendKeys("a");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='secname']"));
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='mail']")).SendKeys("a@a.pl");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("123123123");
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/div[5]/input"));
            button.Click();
            Thread.Sleep(1000);
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/form/h1"));
            Assert.IsFalse(button2.Text.Contains("Niepoprawny numer telefonu lub adres e-mail. Spróbuj ponownie"));
            driver.Close();
            driver.Quit();
        }
    }
}