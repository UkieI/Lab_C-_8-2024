
namespace Lab5
{
    public class Product
    {
        public int ID {set; get;}
        public string Name {set; get;}         // tên
        public double Price {set; get;}        // giá
        public string[] Colors {set; get;}     // các màu sắc
        public int Brand {set; get;}           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
        => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";

        // In ra các sản phẩm có giá 400
        public static void ProductPrice400(List<Product> products)
        {
            // Viết câu quy vấn, lưu vào ketqua
            var ketqua = from product in products
                        where product.Price == 400
                        select product;

            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
        }

        public static void ProductPriceOver500_StartGiuong(List<Product> products)
        {
            // Viết câu quy vấn, lưu vào ketqua
            var ketqua = from product in products
                where product.Price >= 500
                where product.Name.StartsWith("Giường")
                select product;

            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
        }
        public static void ProductPriceLower500_ColorYellow(List<Product> products)
        {
            // Viết câu quy vấn, lưu vào ketqua
            var ketqua = from product in products
                        from color in product.Colors
                        where product.Price < 500
                        where color == "Vàng"
                        select product;

            foreach (var product in ketqua) Console.WriteLine(product.ToString());
        }
    }

    public class  Brand {
        public string Name {set; get;}
        public int ID {set; get;}
    }


    public class EX3_1_LINQ {
        public static void run()
        {   
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
            // 3
            // var ketqua = from product in products
            //     where product.Price <= 300
            //     orderby product.Price descending
            //     select product;

            // 4
            // var ketqua = from product in products
            //             where product.Price >=400 && product.Price <= 500
            //             group product by product.Price;
            // foreach (var group in ketqua)
            // {
            //     // Key là giá trị dùng để phân loại (nhóm): là giá
            //     Console.WriteLine(group.Key);
            //     foreach (var product in group)
            //     {
            //         Console.WriteLine($"    {product.Name} - {product.Price}");
            //     }
            // }
            
            // //5
            // var ketqua = from product in products                 
            //     group product by product.Price into gr    
            //     let count = gr.Count()                    
            //     select new {                              
            //         price = gr.Key,
            //         number_product = count
            //     };

            // foreach (var item in ketqua)
            // {
            //     Console.WriteLine($"{item.price} - {item.number_product}");
            // } 

            // 6
            var ketqua = from product in products
                join brand in brands on product.Brand equals brand.ID
                select new {
                    name  = product.Name,
                    brand = brand.Name,
                    price = product.Price
                };
            foreach (var item in ketqua)
            {
                Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
            }
        }
    }

}
