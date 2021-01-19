using System;
using System.Device.Gpio;
using System.Device.Gpio.Drivers;
using System.Threading;
using System.Threading.Tasks;

namespace pushBlink
{
    class Program
    {
        private static GpioController controller;
        private static int buttonPin = 5;
        private static int LEDPin = 6;

        static void Main(string[] args)
        {
            SetupGPIO();

            Run();
        }
  
        private static Task Run()
        {
            var done = false;
            while (!done)
            {
                var status = controller.Read(buttonPin);
                
                if (status == PinValue.Low)
                    System.Console.WriteLine("Button Pressed!!!");

                Thread.Sleep(100);
            }

            return Task.CompletedTask;
        }

        private static void SetupGPIO()
        {
            Console.WriteLine("Setting up GPIO...");
            controller = new GpioController(0, new RaspberryPi3Driver());

            controller.OpenPin(buttonPin, PinMode.InputPullUp);
        }
    }
}
