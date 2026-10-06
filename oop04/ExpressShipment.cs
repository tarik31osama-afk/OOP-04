namespace oop04
{
    public class ExpressShipment:Shipment
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
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
    }
}
