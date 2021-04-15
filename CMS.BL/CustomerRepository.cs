using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        ///<summary>
        ///Retrieve one customer.
        ///</summary>
        public Customer Retrieve(int customerId)
        {
            //create the instance of the customer class.
            //pass in the requested Id
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer

            //Temporary hard-coded values to return
            //a populated customer

            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        ///<summary>
        ///Saves the current customer.
        ///</summary>
        ///<returns></returns>
        public bool Save(Customer customer)
        {
            //code that saves the passed in customer.
            return true;
        }
    }
}
