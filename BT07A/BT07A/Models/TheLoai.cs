using System;
using System.ComponentModel.DataAnnotations;

namespace BaiTap07A.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public DateTime DataCreated { get; set; } = DateTime.Now;
    }
}