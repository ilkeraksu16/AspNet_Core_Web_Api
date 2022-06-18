namespace NLayerApp.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }

        /*
         public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Category Category2 { get; set; }

        Eğer yukarıdaki gibi bir foreigkey id tanımlaması yapsaydık, Category2 nesnesi üzerinden Foreigkey attiribute ile belirtmemiz gerekecektik, Yukarıdaki gibi best practics tanımlamayla gerek kalmadı.
         
         */
    }
}
