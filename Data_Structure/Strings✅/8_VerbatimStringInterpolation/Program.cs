using System;

namespace pr8
{
    class q8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__String Verbatim Interpolation__");
            var infoCar = (Brand: "Suzuki", ModelName: "Jimny", CarType: "SUV", EngineType: "4/4 type.\n");
            Console.WriteLine($@"Comany: {infoCar.Brand} is Indian-Japanese Car.
                The {infoCar.Brand} releases its new model is {infoCar.ModelName}
                and it is a {infoCar.CarType} luxurious car with engine type {infoCar.EngineType}");
        }
    }
}