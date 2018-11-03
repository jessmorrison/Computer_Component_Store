using Computer_Component_Store.Data;

namespace Computer_Component_Store.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public string CompatibilityType { get; set; }
        public ComputerComponentProduct[] ComputerComponentProducts { get; set; }
    }
}


