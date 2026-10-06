namespace oop04
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        public string CenterName;

        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingcode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingcode)
                        return shipments[i];
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for(int i = 0;i < shipments.Length;i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    for(int j=i;j< shipments.Length-1;j++)
                    {

                        shipments[j] = shipments[j + 1];

                    }
                    shipments[shipments.Length - 1] = null;

                    return true;
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            
            for(int i=0;i< shipments.Length; i++)
            {
                if(shipments[i]!= null)
                shipments[i].PrintShipment();
            }
        }





    }
}

