
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter vehicle Type");
            string userInput =Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userInput);

            Console.WriteLine("Vehicle type :" + vehicle.VehicleType());
            Console.WriteLine("Numbers of Wheels :"+ vehicle.NumberOfWheels());

        }
    }
}