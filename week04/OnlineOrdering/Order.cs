using System.ComponentModel.Design;
using System.Dynamic;
using System.Transactions;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void viewListOfProduct()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            Product currentProduct = _products[i]; 
            Console.WriteLine($"{currentProduct.GetId()}, {currentProduct.GetName()}, {currentProduct.GetPrice()}, {currentProduct.GetQuantity()}"); 
        }
    }


    // calculate the total cost of the order
    public double CalculateTotalCost()
    {
        int shippingCost = 5;
        double allProductSum = 0; 
        // to check if the customer is from USA
        if (!_customer.GetAddress().IsAddressInUsa())
        {
            shippingCost = 35;
        }

        for (int i = 0; i < _products.Count; i++)
        {
            Product currentProduct = _products[i];
            double totalOfEachProduct = currentProduct.GetTotalPrice();
            allProductSum += totalOfEachProduct;
        }

        return allProductSum + shippingCost;
    }
    
}