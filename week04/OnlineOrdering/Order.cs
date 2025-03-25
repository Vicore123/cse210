public class Order {
   private List<Product> _products;
   private Customer _customer;
   private float _shippingCost;

   public Order(List<Product> products, Customer customer) {
      _products = products;
      _customer = customer;

      if (_customer.IsUSA()) {
         _shippingCost = 5;
      }
      else {
         _shippingCost = 35;
      }
   }

   public float GetTotalPrice() {
      float total = 0;
      foreach (Product product in _products) {
         total += product.GetPrice();
      }
      return total + _shippingCost;
   }

   public string GetPackingLabel() {
      string list = "";
      foreach (Product product in _products) {
         list += $"- {product.GetName()} #{product.GetID()}\n";
      }
      
      return $"Packing Label:\n{list}";
   }

   public string GetShippingLabel() {
   
      return $"To {_customer.GetName()} \nAddress: \n{_customer.GetAddress().GetAddress()}\n";
   }


}