// Jayton Crockett
class Customer{
    private string _customer_name;
    private Address _address;
    public Customer(string customer, Address address){
        this._customer_name = customer;
        this._address = address;
    }
    public string getName(){
        return _customer_name;
    }
    public bool usaLocation(){
        return _address.usaLocation();
    }
    public Address getAddress(){
        return _address;
    }
}