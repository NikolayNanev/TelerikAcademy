using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        string result = PrintNameMethod.HelloMethod("Marin");
        Assert.AreEqual("Hello,Marin.", result);
    }

    [TestMethod]
    public void TestMethod2()
    {
        string result = PrintNameMethod.HelloMethod("Pesho");
        Assert.AreEqual("Hello,Pesho.", result);
    }
}