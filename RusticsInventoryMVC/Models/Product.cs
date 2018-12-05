//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RusticsInventoryMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductMaterials = new HashSet<ProductMaterial>();
        }
    
        public int ProductID { get; set; }

        [Required, DisplayName("Product Name"), StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DisplayName("Date Created")]
        public System.DateTime CreateDate { get; set; }

        [DisplayName("Last Modified")]
        public System.DateTime ModifyDate { get; set; }

        [DisplayName("How To")]
        public string HowTo { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [DataType(DataType.Currency)]
        public Nullable<decimal> Price { get; set; }

        public Nullable<decimal> Weight { get; set; }

        public string Size { get; set; }

        [DisplayName("Category")]
        public Nullable<int> CategoryID { get; set; }

        [DisplayName("On Hand")]
        public Nullable<int> AmountOnHand { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DisplayName("Materials Used")]
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}