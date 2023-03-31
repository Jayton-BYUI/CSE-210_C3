// Jayton Crockett
class Product{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity){
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public string getName(){
        return _name;
    }

    public string getProductID(){
        return _productId;
    }

    public double getPrice(){
        double overProve = _price * _quantity;
        return overProve;
    }

    public int getQuantity(){
        return  _quantity;
    }
}
