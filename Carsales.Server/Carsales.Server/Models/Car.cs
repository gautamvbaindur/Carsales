namespace Carsales.Server.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string SellerType { get; set; }
        public string Comments { get; set; }
    }

}   