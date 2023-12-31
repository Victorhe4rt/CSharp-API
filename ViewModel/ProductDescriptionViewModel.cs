﻿using webApiCrud.Models;

namespace webApiCrud.ViewModel
{
    public class ProductDescriptionViewModel
    {
    

        /// <summary>
        /// Description of the product.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
      
    }
}
