namespace PetStore
{
    public class Hampster : IPetAnimal
    {
        public int Inventory { get; set; } = 0;
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}