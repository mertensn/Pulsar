using System.Collections.Generic;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    public class ControllerValueInitializer
    {
        public void InitializeDefaultDatabaseValues()
        {
            var defaultControllerValues = new List<ControllerValue>
            {
                _createControllerValue("CoreController", "ruleTimer", "60"),
                _createControllerValue("CoreController", "sensorTimer", "60")
            };

            foreach (var controllerValue in defaultControllerValues)
                From.HouseManagerDataSource.AddControllerValue(controllerValue);
        }

        private ControllerValue _createControllerValue(string controller, string controllerComponent, string value)
        {
            return new ControllerValue
            {
                Controller = controller,
                ControllerComponent = controllerComponent,
                Value = value
            };
        }
    }
}