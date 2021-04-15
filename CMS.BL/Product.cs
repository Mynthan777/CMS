using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuci.Common;

namespace CMS.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string productname;
        public string ProductName
        {
            get
            {
                return productname.InsertSpaces();
            }
            set
            {
                productname = value;
            }
        }

        public string Log =>$"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;

        ///<summary>
        ///Validates the product data.
        ///</summary>
        ///<returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
