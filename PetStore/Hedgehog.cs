namespace PetStore
{
    public class Hedgehog : IPetAnimal
    {
        public int Inventory { get; set; } = 0;
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public string CuteLevel { get; set; }
    }
}