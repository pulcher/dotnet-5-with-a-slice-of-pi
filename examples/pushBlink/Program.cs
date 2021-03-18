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
        private static int constantBlinkPin = 16;
        private static bool contanstState = false;
        private static int activatedBlinkPin = 6;

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
                {
                    System.Console.WriteLine("Button Pressed!!!");
                    controller.Write(activatedBlinkPin, PinValue.High);
                }
                else 
                {
                    controller.Write(activatedBlinkPin, PinValue.Low);
                }

                if (contanstState)
                    controller.Write(constantBlinkPin, PinValue.High);
                else
                    controller.Write(constantBlinkPin, PinValue.Low);

                contanstState = !contanstState;

                Thread.Sleep(100);
            }

            return Task.CompletedTask;
        }

        private static void SetupGPIO()
        {
            Console.WriteLine("Setting up GPIO...");
            controller = new GpioController(0, new RaspberryPi3Driver());

            Console.WriteLine("Initiating pullup on button....");
            controller.OpenPin(buttonPin, PinMode.InputPullUp);

            Console.WriteLine("Initializing LED indicators...");
            controller.OpenPin(constantBlinkPin, PinMode.Output);
            controller.OpenPin(activatedBlinkPin, PinMode.Output);
        }
    }
}
