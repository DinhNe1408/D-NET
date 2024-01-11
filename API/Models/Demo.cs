namespace API.Models
{
    public class Demo
    {
        public class Car
        {
            public int Passengers { get; set; }
        }

        public class DeliveryTruck
        {
            public int GrossWeightClass { get; set; }
        }

        public class Taxi
        {
            public int Fares { get; set; }
        }

        public class Bus
        {
            public int Capacity { get; set; }
            public int Riders { get; set; }
        }
    }
}