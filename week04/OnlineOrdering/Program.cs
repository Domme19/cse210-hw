using System;
using System.Dynamic;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        // Test products
        // Product laptop = new Product("ZenBook 14", "LAP-001X", 999.99, 15);
        // Product shoes = new Product("CloudRunner Sneaker", "SH-9921", 125.00, 40);
        // Product lamp = new Product("Minimalist Desk Lamp", "HOME-LMP-04", 45.75, 8);
        // Product coffee = new Product("Ethiopian Roast", "GRO-552", 18.50, 142);

        // Console.WriteLine($"The product is: Id: {laptop.GetId()} {laptop.GetName()}   {laptop.GetPrice()} {laptop.GetQuantity()}");


        // // Testing Address
        // Address home = new Address(123, "Maple Avenue", "Springfield", "Illinois", "USA");
        // Address londonOffice = new Address(10, "Downing Street", "London", "Greater London", "UK");
        // Address techHub = new Address(1600, "Amphitheatre Parkway", "Mountain View", "California", "USA");

        // Console.WriteLine($"Address: {home.FullAddress()}"); 


        // Testing customer class
        Product laptop = new Product("ZenBook 14", "LAP-001X", 999.99, 15);
        Product shoes = new Product("CloudRunner Sneaker", "SH-9921", 125.00, 40);
        Product lamp = new Product("Minimalist Desk Lamp", "HOME-LMP-04", 45.75, 8);
        List <Product> productList = [laptop, shoes, lamp];

        Address customerAddress = new Address(742, "Evergreen Terrace", "Springfield", "IL", "USA");
        Customer newCustomer = new Customer("Homer", "Simpson", customerAddress);
        Console.WriteLine($"{newCustomer.GetFirstName()}, {newCustomer.GetLastName()} @ {newCustomer.GetAddress()}");

        // Order products
        Order newOrder = new Order(newCustomer, productList);
        newOrder.viewListOfProduct(); 


    }
}