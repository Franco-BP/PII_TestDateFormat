namespace Library.Tests;
using TestDateFormat;

[TestFixture]
public class DateFormatterTests
{
    [Test]
    public void TestRightFormat()
    {
        string test1 = "03/10/2022";
        const string expected1 = "2022-10-03";
        string result1 = DateFormatter.ChangeFormat(test1);
        Assert.That(result1, Is.EqualTo(expected1));
    }
    //Comando para hacer el testing: dotnet test Library.Tests.csproj

    [Test]
    public void TestWrongFormat()
    {
        string test2 = "2022/10/03";
        string expected2 = $"La cadena ingresada: '{test2}' no tiene un formato: 'dd/mm/yyyy'.";
        string result2 = DateFormatter.ChangeFormat(test2);
        Assert.That(result2, Is.EqualTo(expected2));
    }

    [Test]
    public void TestEmpty()
    {
        string test3 = "";
        string expected3 = $"La cadena ingresada: '{test3}' no tiene un formato: 'dd/mm/yyyy'.";
        string result3 = DateFormatter.ChangeFormat(test3);
        Assert.That(result3, Is.EqualTo(expected3));
    }
}