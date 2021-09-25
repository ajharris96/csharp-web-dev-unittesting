using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car testcar;

        [TestInitialize]
        public void CreateCarObject()
        {
            testcar = new Car("Mazda", "3", 10, 50);
        }

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(testcar.GasTankLevel, 10, 0.001);
        }

        [TestMethod]
        public void TestAfterDrive()
        {
            testcar.Drive(50);
            Assert.AreEqual(9, testcar.GasTankLevel, .001);

        }

        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            testcar.Drive(501);
            Assert.AreEqual(0, testcar.GasTankLevel, .001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            testcar.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
