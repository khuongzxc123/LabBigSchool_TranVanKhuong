using System.ComponentModel.DataAnnotations;

namespace LabBigSchool_TranVanKhuong.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}