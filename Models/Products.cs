namespace ClinicaCaniZzoo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Sales = new HashSet<Sales>();
        }

        [Key]
        public int IdProdotto { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeProdotto { get; set; }

        [Required]
        public int? IdFornitore { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoProdotto { get; set; }

        [Required]
        [StringLength(255)]
        public string UsiProdotto { get; set; }

        [Required]
        public string ImgProdotto { get; set; }

        [Required]
        [StringLength(50)]
        public string Armadietto { get; set; }

        [Required]
        [StringLength(50)]
        public string Cassetto { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
