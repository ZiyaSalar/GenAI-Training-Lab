class Product{
    public Action<string> ProductAdded;
    
    public void addProduct(string name)
    {
        Console.WriteLine($"saving{name}");
        ProductAdded?.Invoke(name);
    }
}


class Program{
    public static void Main(String[] args){
        Product p1=new Product();
        p1.ProductAdded += name => Console.WriteLine($"{name} Email Notified");
        p1.ProductAdded += name => Console.WriteLine($"{name} mssg Notified");

        p1.addProduct("Laptop");
    }
}