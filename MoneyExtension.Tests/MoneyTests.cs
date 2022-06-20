using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyTests
{
  [TestMethod]
  public void ToCentsTest()
  {
    var value = 102.80M;
    var result = value.ToCents();

    Assert.AreEqual(10280, result);
  }
}