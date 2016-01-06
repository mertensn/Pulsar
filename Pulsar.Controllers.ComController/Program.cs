using System;
using System.IO.Ports;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Processor;

namespace Pulsar.Controllers.ComController
{
    class Program
    {
        private static SerialPort _sPort;
        static void Main(string[] args)
        {
            const string sPortname = "COM4";
            try
            {
                _sPort = new SerialPort(sPortname, 115200);
                _sPort.Open();
                _sPort.DataReceived += new SerialDataReceivedEventHandler(sPort_DataReceived);
            }
            catch (Exception ex)
            {
                Console.WriteLine("E_PUL_COMC.001: SerialPort " + sPortname + " could not be opened for reason " + ex);
                From.HouseManagerDataSource.AddPulsarLog(
                    typeof(Program).Namespace, typeof(Program).ToString(), "Pulsar.Controllers.ComController",
                    "Main", DeviceType.Controller, "ComController:Main", From.HouseManagerDataSource.GetLocation("Home").Id,
                    RomanceStandardTime.ToString() +
                    " ComController generated an exception " + ex);
            }
            Console.ReadLine();
        }

        private static void sPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var message = _sPort.ReadLine();
            Console.WriteLine("Message Received " + message);
            new SensorProcessor().ProcessMySensorsMessage(message);
        }
    }
}
