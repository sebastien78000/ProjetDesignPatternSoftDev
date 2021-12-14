using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetDesignPatternSoftDev;
using System;

namespace UnitTest_Monopoly
{
    [TestClass]
    public class TestMonopoly
    {
        [TestMethod]
        public void TestSingleton()
        {
            // Arrange
            Monopoly first = Monopoly.GetMonopoly();
            Monopoly second = Monopoly.GetMonopoly();

            // Act


            // Assert
            Assert.AreSame(first, second);
        }
    }
}
