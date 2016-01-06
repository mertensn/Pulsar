using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class ControllerValueRepositoryTests : ScopedTestBase
    {
        private ControllerValue _controllerValue;

        [SetUp]
        public void SetUp()
        {
            _controllerValue = From.HouseManagerDataSource.AddControllerValue(new ControllerValue
            {
                Controller = "TestController",
                ControllerComponent = "TestSensorTimer",
                Value = "60000"
            });
        }

        [Test]
        public void Given_ControllerValueAddedToDB_ObjectCanBeFetched()
        {
            var controllerValueFromDb = From.HouseManagerDataSource.GetControllerValue(_controllerValue.Controller,
                _controllerValue.ControllerComponent);

            Assert.IsNotNull(controllerValueFromDb.Id);
            Assert.IsNotNull(controllerValueFromDb.RowCreated);
            Assert.AreEqual(controllerValueFromDb.Controller, _controllerValue.Controller);
            Assert.AreEqual(controllerValueFromDb.ControllerComponent, _controllerValue.ControllerComponent);
            Assert.AreEqual(controllerValueFromDb.Value,_controllerValue.Value);
        }

        [Test]
        [TestCase("TestController", "", "")]
        [TestCase("", "TestControllerComponent", "")]
        [TestCase("", "TestControllerComponent", "TestValue")]
        [TestCase("TestController", "TestControllerComponent", "")]
        [TestCase("", "", "TestValue")]
        [TestCase("TestController", "", "TestValue")]
        [TestCase("TestController", null, null)]
        [TestCase("", "TestControllerComponent", "")]
        [TestCase(null, "TestControllerComponent", "TestValue")]
        [TestCase("TestController", "TestControllerComponent", null)]
        [TestCase(null, null, "TestValue")]
        [TestCase("TestController", null, "TestValue")]
        [ExpectedPulsarException("E_PUL_IDC.028")]
        public void Given_ControllerValueAddedWithIncorrectInputParameters_ThrowsException(string controller, string controllerComponent, string value)
        {
            From.HouseManagerDataSource.AddControllerValue(new ControllerValue
            {
                Controller = controller,
                ControllerComponent = controllerComponent,
                Value = value
            });
        }

        [Test]
        public void Given_GetAllControllerValues_ReturnsItems()
        {
            var controllerValues = From.HouseManagerDataSource.GetAllControllerValues();

            Assert.IsNotNull(controllerValues);
            Assert.IsTrue(controllerValues.Any());
        }
    }
}