using System;
using System.Collections.Generic;

namespace webApiCrud.Models;

/// <summary>
/// Product descriptions in several languages.
/// </summary>
public partial class ProductDescription
{
    public ProductDescription()
    {
    }

   

    public ProductDescription(string description, Guid rowguid, DateTime modifiedDate)
    {
        Description = description;
        Rowguid = rowguid;
        ModifiedDate = modifiedDate;
 
    }

    public ProductDescription(string description)
    {
        Description = description;
       
    }
    /// <summary>
    /// Primary key for ProductDescription records.
    /// </summary>
    public int ?ProductDescriptionId { get; set; }

    /// <summary>
    /// Description of the product.
    /// </summary>
    public string ?Description { get; set; } = null!;

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid ?Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

   
}
