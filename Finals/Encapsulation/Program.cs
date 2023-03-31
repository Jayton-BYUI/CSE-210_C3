// Jayton Crockett
class Program{
    static void Main(string[] args){
        Address address1 = new Address("345 S 2nd E APT 99", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Mike Hambin", address1);
        List<Product> product1 = new List<Product>(){
            new Product("Flip Flops", "AS12", 12.99, 1),
            new Product("Doritos", "L567", 4.99, 4)
        };

        Address add02 = new Address("15028 W Becker Ln", "Suprise", "AZ", "USA");
        Customer customer2 = new Customer("Taylee Crockett", address1);
        List<Product> product2 = new List<Product>(){
            new Product("Iphone 13 phone case", "I400", 11.99, 1),
            new Product("Swimming Suit", "CS34", 22.99, 2),
            new Product("CeraVa", "FC21", 16.99, 1)
        };

        Order order1 = new Order(product1, customer1);
        Order order2 = new Order(product2, customer2);

        Console.WriteLine($"{order1.product_num()} \n{order1.location()} \n{order1.total():C}\n");
        Console.WriteLine($"{order2.product_num()} \n{order2.location()} \n{order2.total():C}\n");
    }
}