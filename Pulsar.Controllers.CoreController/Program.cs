using System;
using System.Net.Http;
using System.Timers;
using Framework.Date;
using Microsoft.Azure.WebJobs;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Controllers.CoreController
{
    class Program
    {
        private static readonly TaskFactory TaskFactory = new TaskFactory();

        static void Main()
        {
            var host = new JobHost();
            _initCoreController();

            Console.ReadLine();
            host.RunAndBlock();
        }

        private static void _initCoreController()
        {
            try
            {
                var ruleTimerValue = _getTimerValue("ruleTimer") * 1000;
                var sensorTimerValue = _getTimerValue("sensorTimer") * 1000;

                var ruleTimer = new Timer(ruleTimerValue);
                var sensorTimer = new Timer(sensorTimerValue);

                ruleTimer.Elapsed += ruleTtimer_Elapsed;
                sensorTimer.Elapsed += sensorTimer_Elapsed;

                ruleTimer.Start();
                _initTimerLog("ruleTimer", ruleTimerValue);

                sensorTimer.Start();
                _initTimerLog("sensorTimer", sensorTimerValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("E_PUL_CORC.001: CoreController received an exception " + ex);
                From.HouseManagerDataSource.AddPulsarLog(
                     typeof(Program).Namespace, typeof(Program).ToString(), "Pulsar.Controllers.CoreController",
                     "Main", DeviceType.Controller, "CoreController:Main", From.HouseManagerDataSource.GetLocation("Home").Id,
                     RomanceStandardTime.ToString() +
                     " CoreController generated an exception " + ex);
            }
        }

        private static void ruleTtimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //TODO NICOLAS If the Build framework is implemented, add a config param to set the Environment and then check for it here
            TaskFactory.ExecutePingTask("http://www.mertensn.nl/pulsar/api/ping");
            TaskFactory.ExecuteRuleTask();
        }

        private static void sensorTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TaskFactory.ExecuteSensorTask();
        }

        private static int _getMinutes(double milliseconds)
        {
            return TimeSpan.FromMilliseconds(milliseconds).Minutes;
        }

        private static int _getTimerValue(string timer)
        {
            return int.Parse(From.HouseManagerDataSource.GetControllerValue("CoreController", timer).Value);
        }

        private static void _initTimerLog(string timer, double timerValue)
        {
            Console.WriteLine(RomanceStandardTime.ToString() +
                              ": Pulsar.Controllers.CoreController " + timer + " started. Working every " +
                              _getMinutes(timerValue) + " minute(s)");

            From.HouseManagerDataSource.AddPulsarLog(
                typeof(Program).Namespace, typeof(Program).ToString(), "Pulsar.Controllers.CoreController",
                timer + ".Start", DeviceType.Internal, "CoreController:Start" + timer,
                From.HouseManagerDataSource.GetLocation("Internal").Id,
                RomanceStandardTime.ToString() + " Pulsar.Controllers.CoreController " + timer + " started. Working every " +
                              _getMinutes(timerValue) + " minute(s)");
        }
    }
}
