using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class OrderRepository
    {
        ///<summary>
        ///Retrieve one order.
        ///</summary>
        public Order Retrieve(int orderId)
        {
            //create the instance of the order class
            //pass in the requested Id
            Order order = new Order(orderId);

            //code that retrieves the defined order

            //temporary hard-coded values to return
            //a populated order
            if(orderId == 10)
            {
                //use curent year in hard-codeed data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        ///<summary>
        ///Saves the current order.
        ///</summary>
        ///<returns></returns>
        public bool Save(Order order)
        {
            //code that saves the passed in order.
            return true;
        }
    }
}
