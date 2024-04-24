using Newtonsoft.Json;


    class Program
    {
        static void Main(string[] args)
        {
            string json = @"
            {
                'products': [
                    {
                        'productId': '1',
                        'productName': 'Laptop',
                        'price': 699,
                        'quantity': 10
                    },
                    {
                        'productId': '2',
                        'productName': 'phone',
                        'price': 599,
                        'quantity': 20
                    },
                    {
                        'productId': '3',
                        'productName': 'Headphones',
                        'price': 99,
                        'quantity': 30
                    },
                    {
                        'productId': '4',
                        'productName': 'Tab',
                        'price': 299,
                        'quantity': 15
                    },
                    {
                        'productId': '5',
                        'productName': 'watch',
                        'price': 199,
                        'quantity': 25
                    }
                ]
            }";

            dynamic jsonObj = JsonConvert.DeserializeObject(json);

            foreach (var product in jsonObj.products)
            {
                Console.WriteLine($"Product ID: {product.productId}, Product Name: {product.productName}, Price: {product.price}, Quantity: {product.quantity}");
            }
    }
}

