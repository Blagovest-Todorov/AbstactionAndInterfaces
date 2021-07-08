using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Gray");
            Car tesla = new Tesla(2, "Model3", "Red");           
            
            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
}
