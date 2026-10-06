namespace oop04
{
    public class ExpressShipment:Shipment, ITrackable, IInsurable
    {
        private decimal extrafee;
        public ExpressShipment(string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress Destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, Destination) 
        {
            ExtraFee = extraFee;
        
        }
        public decimal ExtraFee 
        {
            get
            {
                return extrafee;
            }
            set
            {
                if (value >= 0)
                {
                    extrafee = value;
                }
            }
        }
        
       public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
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
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }
        public decimal CalculateInsurance()
        {
            return (0.08m * EstimatedCost);
        }
    }
}
