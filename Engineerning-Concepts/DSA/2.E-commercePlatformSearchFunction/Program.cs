using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }

        return null;
    }

    static Product BinarySearch(Product[] products, int targetId)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].ProductId == targetId)
                return products[mid];

            if (products[mid].ProductId < targetId)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mobile", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories"),
            new Product(105, "Book", "Education")
        };

        Console.WriteLine("Linear Search:");

        Product linearResult = LinearSearch(products, 104);

        if (linearResult != null)
            Console.WriteLine($"Found: {linearResult.ProductName}");
        else
            Console.WriteLine("Product not found");

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Product binaryResult = BinarySearch(products, 104);

        if (binaryResult != null)
            Console.WriteLine($"Found: {binaryResult.ProductName}");
        else
            Console.WriteLine("Product not found");
    }
}
