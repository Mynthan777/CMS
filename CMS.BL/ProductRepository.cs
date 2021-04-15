﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class ProductRepository
    {
        ///<summary>
        ///Retrieve one prduct.
        ///</summary>
        public Product Retrieve(int productId)
        {
            //create the instance of the product class
            //pass in the requested Id
            Product product = new Product(productId);
            //code that retrieves the defined product

            //temporary hard-coded values o return
            //a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Product:{product.ToString()}");
            return product;
        }

        ///<summary>
        ///Saves the current product.
        ///</summary>
        ///<returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an Insert stored procedure
                    }
                    else
                    {
                        //call an Update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
