using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Authors
{
    [Table("Author")]
    public class Author
    {
        [Key]
        [Column("BusinessEntityID")]
        public int BusinessEntityID { get; set; }

        [Required]
        [StringLength(15)]
        [Column("NationalIDNumber")]
        public string NationalIDNumber { get; set; }

        [Required]
        [StringLength(256)]
        [Column("LoginID")]
        public string LoginID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("JobTitle")]
        public string JobTitle { get; set; }

        [Required]
        [Column("BirthDate")]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(1)]
        [Column("MaritalStatus")]
        public string MaritalStatus { get; set; }

        [Required]
        [StringLength(1)]
        [Column("Gender")]
        public string Gender { get; set; }

        [Required]
        [Column("HireDate")]
        public DateTime HireDate { get; set; }

        [Required]
        [Column("VacationHours")]
        public short VacationHours { get; set; }
        
        [Required]
        [Column("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }
    }
}
