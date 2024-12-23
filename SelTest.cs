using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private IWebDriver _driver;

    [SetUp]
    public void SetUp()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl("http://localhost:5000"); // Убедитесь, что ваш веб-сервер запущен по этому адресу
    }

    [Test]
    public void TestAddition()
    {
        _driver.FindElement(By.Id("inputA")).SendKeys("5");
        _driver.FindElement(By.Id("inputB")).SendKeys("3");
        _driver.FindElement(By.Id("addButton")).Click();

        var result = _driver.FindElement(By.Id("result")).Text;
        Assert.Equals("8", result);
    }

    [Test]
    public void TestSubtraction()
    {
        _driver.FindElement(By.Id("inputA")).SendKeys("10");
        _driver.FindElement(By.Id("inputB")).SendKeys("4");
        _driver.FindElement(By.Id("subtractButton")).Click();

        var result = _driver.FindElement(By.Id("result")).Text;
        Assert.Equals("6", result);
    }

    [Test]
    public void TestDivisionByZero()
    {
        _driver.FindElement(By.Id("inputA")).SendKeys("5");
        _driver.FindElement(By.Id("inputB")).SendKeys("0");
        _driver.FindElement(By.Id("divideButton")).Click();

        var result = _driver.FindElement(By.Id("error")).Text;
        Assert.IsTrue(result.Contains("Cannot divide by zero"));
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
    }
}
