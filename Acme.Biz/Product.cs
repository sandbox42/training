using Acme.Common;
using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors
        public Product()
        {
            
            #region Generic List
            var colourOptions = new List<string>()
                                    { "Red", "White", "Yellow", "Green" };

            //var colourOptions = new List<string>();
            //colourOptions.Add("Red");
            //colourOptions.Add("Yellow");
            //colourOptions.Add("Green");
            //colourOptions.Add("Orange");
            //colourOptions.Insert(1, "mauve");
            //colourOptions.Remove("Green");
            Console.WriteLine(colourOptions);

            //string[] colourOptions = { "red", "yellow", "orange", "green" };

            //var yellowindex = Array.IndexOf(colourOptions, "yellow");

            //colourOptions.SetValue("amber", 3);

            //for (int i = 0; i < colourOptions.Length; i++)
            //{
            //    colourOptions[i] = colourOptions[i].ToUpper();

            //}

            //foreach (var item in colourOptions)
            //{
            //    Console.WriteLine($"The colour is {item}");
            //}

            //Console.WriteLine(colourOptions[1]);
            #endregion

            var states = new Dictionary<string, string>()
            {
                {"CA", "California" },
                {"WA", "Washington" },
                {"NY", "New York" },
            };


            //states.Add("CA", "California");
            //states.Add("WA", "Washington");
            //states.Add("NY", "New York");
            Console.WriteLine(states);
        }
        public Product(int productId,
                        string productName,
                        string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

        }
        

        #region Properties
        public DateTime? AvailabilityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int ProductId { get; set; }

        private string productName;
        public string ProductName
        {
            get {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";

                }
                else
                {
                    productName = value;

                }
            }
        }

        private Vendor productVendor;
        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }

        public string ValidationMessage { get; private set; }

        #endregion

        /// <summary>
        /// Calculates the suggested retail price
        /// </summary>
        /// <param name="markupPercent">Percent used to mark up the cost.</param>
        /// <returns></returns>
        public decimal CalculateSuggestedPrice(decimal markupPercent) =>
             this.Cost + (this.Cost * markupPercent / 100);

        public override string ToString()
        {
            return this.ProductName + " (" + this.ProductId + ")";
        }
    }
}
#endregion