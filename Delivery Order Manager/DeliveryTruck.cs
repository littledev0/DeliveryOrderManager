using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery_Order_Manager
{
    /// <summary>
    /// A class that manages the packages inside of a delivery truck
    /// </summary>
    internal class DeliveryTruck
    {
        #region Variables 

        private int packageCapacity;

        /// <summary>
        /// A list of packages that still need to be delivered 
        /// </summary>
        public List<Package> storedPackages = new List<Package>();

        /// <summary>
        /// A list of packages that have been delivered
        /// </summary>
        public List<Package> deliveredPackages = new List<Package>();

        #endregion

        /// <summary>
        /// Constructor for each delivery truck
        /// </summary>
        /// <param name="packageCapacity">Total number of packages a truck can hold</param>
        public DeliveryTruck(int packageCapacity = 100) {
            this.packageCapacity = packageCapacity;
        }

        /// <summary>
        /// Prints the remaining packages that need to be delivered, grouped by the person they are for 
        /// </summary>
        public void PrintDeliveryList() {
            foreach(var package in storedPackages) {
                Console.WriteLine(package);
            }
        }

        /// <summary>
        /// Adds a package to the truck if it is not filled to capacity 
        /// </summary>
        /// <param name="package">Information about new package</param>
        public void loadPackage(Package package) {
            if (storedPackages.Contains(package) || storedPackages.Count == packageCapacity)
                return;

            if (deliveredPackages.Contains(package)) {
                deliveredPackages.Remove(package);
                package.orderStatus = Package.OrderStatus.Returned;
            }

            storedPackages ??= new List<Package>();
            storedPackages.Add(package);
        }

        /// <summary>
        /// Removes a package from the truck
        /// </summary>
        /// <param name="package">Information about package to remove</param>
        public void deliverPackage(Package package) {
            if (!storedPackages.Contains(package))
                return;

            storedPackages.Remove(package);
            package.orderStatus = Package.OrderStatus.Delivered;

            if (deliveredPackages.Contains(package))
                return; 

            deliveredPackages ??= new List<Package>();
            deliveredPackages.Add(package);
        }
    }
}
