using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Runtime.ExceptionServices;
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

    public string GetPackingLabel()
    {
        string packingLabel = ""; 
        for (int i = 0; i < _products.Count; i++)
        {
            Product currentProduct = _products[i];
            string label = $"{currentProduct.GetName()} - {currentProduct.GetId()}";
            packingLabel += label;
            if (i != _products.Count - 1)
            {
                packingLabel += "\n"; 
            }

        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetFirstName()}, {_customer.GetLastName()} - {_customer.GetFullAddress()}"; 
    }
    
}