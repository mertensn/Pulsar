using System;
using System.Net.Http;
using System.Threading.Tasks;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Processor;

namespace Pulsar.Controllers.CoreController
{
    public class TaskFactory
    {
        public async Task ExecutePingTask(string uri)
        {
            _logTaskWorking("ExecutePingTask");
            await new HttpClient().GetAsync(new Uri(uri));
        }

        public async Task ExecuteRuleTask()
        {
            new RuleProcessor().ExecuteAllRules();
            _logTaskWorking("ExecuteRuleTask");
        }

        public async Task ExecuteSensorTask()
        {
            _logTaskWorking("ExecuteSensorTask");
            new SensorProcessor().ProcessAllSensors();
        }

        private static void _logTaskWorking(string task)
        {
            Console.WriteLine(RomanceStandardTime.ToString() + " Pulsar.Controllers.CoreController.TaskFactory " + task);

            From.HouseManagerDataSource.AddPulsarLog(
                typeof(TaskFactory).Namespace, typeof(TaskFactory).ToString(), "Pulsar.Controllers.CoreController",
                task, DeviceType.Controller, "CoreController:TaskFactory:" + task,
                From.HouseManagerDataSource.GetLocation("Internal").Id,
                RomanceStandardTime.ToString() + " Pulsar.Controllers.CoreController.TaskFactory " + task);
        }
    }
}
