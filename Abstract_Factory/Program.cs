namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetBikeDetails();


            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetCarDetails();

            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetBikeDetails();


            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetCarDetails();
        }
    }
}
