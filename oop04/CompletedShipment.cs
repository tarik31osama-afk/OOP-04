namespace oop04
{
   sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress Destination)
            : base(trackingCode, description, weight, deliveryFee, Destination)
        {

        }
    }
}
