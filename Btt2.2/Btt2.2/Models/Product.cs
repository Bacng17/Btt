namespace Btt2._2.Models
{
    public class Product
    {
        public string Name { get; set; }     
        public string Image { get; set; }    
        public int Price { get; set; }     
        public int GenreId { get; set; }   
        public int Id { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Name = "Tivi TCL QLED 4k 55 inch",
                    Image = "images/google-tivi-qled-tcl-ai-4k-55-inch-55p7k-1-638820357693046205-700x467.jpg",
                    Price = 12500000,
                    GenreId = 1,
                    Id = 1,
                },
                new Product
                {
                    Name = "Tivi Samsung QLED 4k 65 inch",
                    Image = "images/tivi-qled-samsung-4k-65-inch-qa65q65d-1-638687436771499863-700x467.jpg",
                    Price = 15900000,
                    GenreId = 1,
                    Id = 2
                },
                new Product
                {
                    Name = "Tivi Sony 4k 43 inch",
                    Image = "images/google-tivi-sony-4k-43-inch-k-43s25vm2-1-638844796993399464-700x467.jpg",
                    Price = 12500000,
                    GenreId = 1,
                    Id = 3
                },
                new Product
                {
                    Name = "Tivi Xiaomi 4k 43 inch",
                    Image = "images/google-tivi-qled-xiaomi-a-pro-4k-43-inch-l43mb-apsea-2026-1-638824865027611361-700x467.jpg",
                    Price = 13500000,
                    GenreId = 1,
                    Id = 4
                },
                new Product
                {
                    Name = "Tivi LG 4k 75 inch",
                    Image = "images/smart-tivi-lg-ai-4k-75-inch-75ua8450psa-1-638823128249728362-700x467.jpg",
                    Price = 21500000,
                    GenreId = 1,
                    Id = 5
                },
                new Product
                {
                    Name = "Tivi Toshiba 4k 55 inch",
                    Image = "images/smart-tivi-toshiba-ai-4k-55-inch-55c350rp-11-638893189514031294-700x467.jpg",
                    Price = 18500000,
                    GenreId = 1,
                    Id = 6
                }
            };

            return products;
        }
    }
}
