namespace InheritanceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program!");
            //creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");
            //creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");
            //add the two chairs to the IDestroyable list of the car
            //so that when we destroy the car the destroyable objects
            //that are near the car will get destroyed as well
            damagedCar.DestoryablesNearby.Add(officeChair);
            damagedCar.DestoryablesNearby.Add(gamingChair);
            //destory the car
            damagedCar.Destroy();
            //pause
            Console.ReadKey();



        }
    }
}