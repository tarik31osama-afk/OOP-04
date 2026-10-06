namespace oop04
{ 
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private int weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }

            private set

            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }


            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }

            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            
            private set

            {
                if (deliveryFee >= 0)
                {
                    deliveryFee = value;
                }
            }

        }
        public  virtual decimal EstimatedCost 
       {
            get {
               return DeliveryFee + (Weight * 5); 
            }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }
        public Shipment(string trackingCode, string description, int weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public void weight_update(int weight)
        {
           Weight = weight;
            
        }

        public void weight_update(int weight,int extraPackingWeight)
        {
            Weight = weight+ extraPackingWeight;
            
        }


        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
    }
}
