namespace oop04

{
    public class StandardShipment:Shipment
    {

        public StandardShipment(string trackingCode, string description, int weight, decimal deliveryFee , DeliveryAddress Destination) 
            :base(trackingCode, description, weight, deliveryFee,  Destination)
        {
            
        }
        public override void PrintShipment()
        {
            base.PrintShipment();
        }


    }
}
