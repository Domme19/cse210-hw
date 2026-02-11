using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
      
        // For a customer in the US
        Product laptop = new Product("ZenBook 14", "LAP-001X", 999.99, 3);
        Product shoes = new Product("CloudRunner Sneaker", "SH-9921", 125.00, 4);
        Product lamp = new Product("Minimalist Desk Lamp", "HOME-LMP-04", 45.75, 5);
        List <Product> productList = [laptop, shoes, lamp];
        Address customerAddress = new Address(742, "Evergreen Terrace", "Springfield", "IL", "US");
        Customer newCustomer = new Customer("Homer", "Simpson", customerAddress);
        Order newOrder = new Order(newCustomer, productList);
        // Shipping Label
        Console.WriteLine("------Shipping Label-------"); 
        Console.WriteLine(newOrder.GetShippingLabel()); 
        // Packing Label
        Console.WriteLine("------Packing Label-------"); 
        Console.WriteLine(newOrder.GetPackingLabel()); 
        // Total Cost:
        Console.WriteLine($"Total Cost: ${newOrder.CalculateTotalCost()}"); 
        Console.WriteLine();


        // For a customer in the UK
        Product coffee = new Product("Ethiopian Roast", "GRO-552", 18.50, 10);
        Product headphones = new Product("Sony WH-1000XM5", "ELE-441", 348.00, 2);
        Product blender = new Product("Vitamix Explorer", "KIT-112", 289.50, 4);
        List <Product> productList2 = [coffee, headphones, blender];
        Address customer2Address = new Address(10, "Downing Street", "London", "Greater London", "UK");
        Customer secondCustomer = new Customer("John", "Kent", customer2Address);
        Order secondOrder = new Order(secondCustomer, productList2);

         // Shipping Label
        Console.WriteLine("------Shipping Label-------"); 
        Console.WriteLine(secondOrder.GetShippingLabel()); 
        // Packing Label
        Console.WriteLine("------Packing Label-------"); 
        Console.WriteLine(secondOrder.GetPackingLabel()); 
        // Total Cost:
        Console.WriteLine($"Total Cost: ${secondOrder.CalculateTotalCost()}"); 

    }
}