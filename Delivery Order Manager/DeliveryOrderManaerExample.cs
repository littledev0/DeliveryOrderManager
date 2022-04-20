public class DeliveryOrderManaerExample
{
    public static void Main()
    {
        Delivery_Order_Manager.DeliveryTruck truck = new Delivery_Order_Manager.DeliveryTruck();
        truck.loadPackage(new Delivery_Order_Manager.Package("Sam", "Dave", "03/23/2022"));
        truck.loadPackage(new Delivery_Order_Manager.Package("Spencer", "Dave", "03/23/2022"));
        truck.loadPackage(new Delivery_Order_Manager.Package("Debra", "Dave", "03/23/2022"));
        truck.loadPackage(new Delivery_Order_Manager.Package("Debra", "Sam", "03/23/2022"));
        truck.loadPackage(new Delivery_Order_Manager.Package("Dave", "Debra", "03/23/2022"));

        truck.PrintDeliveryList();
    }
}