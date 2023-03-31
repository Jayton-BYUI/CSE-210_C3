class Order{
    private Customer customer;
    private List<Product> products = new List<Product>();
    public Order(List<Product> products, Customer customer){
        this.products = products;
        this.customer = customer;
    }
    public string product_num(){
        string product_label = "";
        foreach(Product product in products){
            product_label += ($"{product.getName()} - {product.getProductID()}\n");
        }
        return product_label;
    }
    public string location(){
        return $"{customer.getName()}\n{customer.getAddress().fulladdress()}\n";
    }
    // Tax depending on the location
    public double total(double total = 0){
        foreach(Product product in products){
            total+= product.getPrice();
        }
        total += customer.usaLocation() ? 5 : 35;
        return total;
    }
}