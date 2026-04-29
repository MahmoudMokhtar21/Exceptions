namespace ConsoleApp20
{
    public class Delivery_Service
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {

            // swallow exception mean stop handling exception by dbl // and with swallowing do atleast one of these steps
            //  inform user
            // log the excepion ,that's mean inform team u work wih or work behind u
            // last step u can do is "Ducking" which mean "rethrowing"
            try
            {
                process(delivery);
                ship(delivery);
                intransit(delivery);
                deliver(delivery);
            }
            catch (AccidentException ex)
            {
                Console.WriteLine($"there was an accident at {ex.Location} prevent us to delivering parcel : {ex.Message}");
                delivery.deliverystatus = DeliveryStatus.UNKNOWN;
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"unable to deliver due to : {ex.Message}");
                delivery.deliverystatus = DeliveryStatus.UNKNOWN;
                //throw;
            }

        }

        private void process(Delivery delivery)
        {
            Fackit("processing");
            if(random.Next(1,5)==1)
            {
                throw new InvalidOperationException($"unable to process staff");
            }
            delivery.deliverystatus = DeliveryStatus.PROCESSED;
        }
        private void ship(Delivery delivery)
        {
            Fackit("shipping");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException($"parcing is damage during the loading process");
            }
            delivery.deliverystatus = DeliveryStatus.SHIPPED;
        }
        private void intransit(Delivery delivery)
        {
            Fackit("on its way");
            if (random.Next(1, 2) == 1)
            {
                throw new AccidentException("alobor sahrawi_street 12 ","Accident !!!");
            }
            delivery.deliverystatus = DeliveryStatus.IN_TRANSIT;
        }
        private void deliver(Delivery delivery)
        {
            Fackit("deivered");
            if (random.Next(1, 2) == 1)  // possibelity is 1 to 10
            {
                throw new WrongAddressException($"'{delivery.Address}' is invalid ");
            }
            delivery.deliverystatus = DeliveryStatus.DELIVERED;
        }

        public void Fackit(string title)
        {
            Console.Write(title);
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
        }

    }
}

