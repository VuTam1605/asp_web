using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_02.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }

        [Required(ErrorMessage = "Tiêu đề sách không được để trống.")]
        public string TieuDeSach { get; set; }

        [Required(ErrorMessage = "Năm xuất bản không được để trống.")]
        [Range(1900, 2100, ErrorMessage = "Năm xuất bản phải trong khoảng từ 1900 đến 2100.")]
        public int NamXuatBan { get; set; }

        [ForeignKey("TacGia")]
        [Required(ErrorMessage = "Mã tác giả không được để trống.")]
        public int MaTacGia { get; set; }

        [Required(ErrorMessage = "Thể loại không được để trống.")]
        public string TheLoai { get; set; }

        // Để TacGiaObj có thể null
        public TacGia? TacGiaObj { get; set; }
    }
}
