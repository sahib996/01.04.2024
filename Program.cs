using _01._04._2024.model;

namespace _01._04._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new Device();

            device.OpenDevice("Device opening…");
            device.OpenDevice("Device already opened");

            device.DeviceClose("Device opening…");
            device.DeviceClose("Device already opened");
        }
    }
}
