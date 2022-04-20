using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Order_Manager
{
    /// <summary>
    /// Class to store information about a package being delivered 
    /// </summary>
    internal class Package
    {
        #region Variables

        public string nameOfSender = "";
        public string nameOfReciever = "";
        public string deliveryDate = "";

        public enum OrderStatus {
            Shipped,
            Delivered,
            Returned
        }

        /// <summary>
        /// Status of package shipment 
        /// </summary>
        public OrderStatus orderStatus = new OrderStatus();

        #endregion

        public Package(string sender, string reciever, string deliveryDate) {
            this.nameOfSender = sender;
            this.nameOfReciever = reciever; 
            this.deliveryDate = deliveryDate;
            this.orderStatus = OrderStatus.Shipped; 
        }

        public override string ToString() {
            return $"Sender: {nameOfSender}, Reciever: {nameOfReciever}, Delivery Date: {deliveryDate}, Order Status: {orderStatus}";
        }
    }
}
