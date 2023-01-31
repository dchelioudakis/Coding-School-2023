namespace LibCarService 
{
    public class Car : EntityBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarRegistrationNumber { get; set; }

        public Car()
        {
            Id = Guid.NewGuid();
        }
    }
}