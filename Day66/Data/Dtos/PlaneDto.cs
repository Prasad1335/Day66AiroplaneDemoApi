namespace Day66.Data.Dtos
{
    public class PlaneDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public long MaxWeightLoadCapacity { get; set; }

        public long MaxFuelLoadCapacity { get; set; }

        public int MileagePerKilometer { get; set; }

      
        public string RegistrationNumber { get; set; } = null!;

        public DateTime ManufacturingDate { get; set; }
    }
}
