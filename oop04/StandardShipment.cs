namespace oop04

{
    public class StandardShipment:Shipment ,ITrackable , IInsurable
    {

        public StandardShipment(string trackingCode, string description, int weight, decimal deliveryFee , DeliveryAddress Destination) 
            :base(trackingCode, description, weight, deliveryFee,  Destination)
        {
            
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

        public  string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        public decimal CalculateInsurance()
        {
            return (0.05m *EstimatedCost);
        }
    }
}
