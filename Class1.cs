using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public DeliveryStatus deliverystatus {  get; set; }

        public override string ToString()
        {
            return $"{{\n   ID : {Id},\n   Customer Name : {CustomerName},\n   Addess : {Address},\n   Status : {deliverystatus}\n}}";
        }
    }
}

