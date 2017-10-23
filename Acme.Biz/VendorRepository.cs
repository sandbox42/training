using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor()
                { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor()
                { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);

            }

            #region foreach example
            //foreach (var vendor in vendors)
            //{
            //  in foreach we can't do this...
            // vendor = new Vendor();

            // but we can do this...
            // vendor.CompanyName = Vendor.CompanyName.ToUpper();

            //    Console.WriteLine(vendor);
            //}
            #endregion


            return vendors;
        }

        /// <summary>
        /// retrieves all the approved vendors, one at a time
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            //get the data from the database
            this.Retrieve();

            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }
        //public Vendor[] RetrieveArray()
        //{
        //    var vendors = new Vendor[2]
        //    {
        //        new Vendor()
        //            { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" } ,
        //        new Vendor()
        //            { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }
        //    };

            //    return vendors;
            //}
            //public  List<Vendor> Retrieve()
            //{
            //    if ( vendors == null)
            //    {
            //        vendors = new List<Vendor>();

            //        vendors.Add(new Vendor()
            //            { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
            //        vendors.Add(new Vendor()
            //        { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            //    }

            //    for (int i = 0; i < vendors.Count; i++)
            //    {
            //        Console.WriteLine(vendors[i]);

            //    }

            //    #region foreach example
            //    //foreach (var vendor in vendors)
            //    //{
            //    //  in foreach we can't do this...
            //    // vendor = new Vendor();

            //    // but we can do this...
            //    // vendor.CompanyName = Vendor.CompanyName.ToUpper();

            //    //    Console.WriteLine(vendor);
            //    //}
            //    #endregion


            //    return vendors;
            //}

            ///// <summary>
            /////  Retrieves all of the approved vendors
            ///// </summary>
            ///// <returns></returns>
            ///// 
            //public Dictionary<string, Vendor> RetrieveWithKeys()
            //{
            //    var vendors = new Dictionary<string, Vendor>()
            //    {
            //        { "ABC Corp", new Vendor()
            //            { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" } } ,
            //        { "XYZ Inc", new Vendor()
            //            { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } }
            //    };

            //    #region Iterating the Elements
            //    //iterate the elements(key and value)
            //    foreach (var element in vendors)
            //    {
            //        var vendor = element.Value;
            //        var key = element.Key;
            //        Console.WriteLine($"Key: {key} Value: {vendor}");
            //    }
            //    #endregion

            //    #region Iterating Element values
            //    //iterate the values
            //    //foreach (var vendor in vendors.Values)
            //    //{
            //    //    Console.WriteLine(vendor);
            //    //} 
            //    #endregion

            //    #region Iterating Element keys
            //    //iterate the keys
            //    //foreach (var companyName in vendors.Keys)
            //    //{
            //    //    Console.WriteLine(companyName);
            //    //} 
            //    #endregion

            //    #region Key lookup
            //    ////this involves 2 lookups
            //    //if (vendors.ContainsKey("XYZ"))
            //    //{
            //    //    Console.WriteLine(vendors["XYZ"]);
            //    //}

            //    ////this involves 1 lookup - better
            //    //Vendor vendor;
            //    //if( vendors.TryGetValue("XYZ", out vendor))
            //    //{
            //    //    Console.WriteLine(vendor);
            //    //}
            //    #endregion


            //    return vendors;
            //}

        public T RetrieveValue<T> (string sql, T defaultValue)
        {
            // call the database to retrieve the value
            // if no value is returned, return the default value 
            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
