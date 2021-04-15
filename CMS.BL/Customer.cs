using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuci.Common;

namespace CMS.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullname = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }

        public static int InstanceCount { get; set; }
        private string lastname;
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public new object EntityState { get; private set; }

        //public string Log()
        //{
        //    var logString = CustomerId + ": " + FullName + " " + "Email: " + EmailAddress + " " + "Status: " + EntityState.ToString();
        //    return logString;
        //}

        public string Log => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState}";
        public override string ToString() => FullName;

        ///<summary>
        ///Validates the customer data.
        ///</summary>
        ///<returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }

}

