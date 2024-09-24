using System.ComponentModel.DataAnnotations;

public class LopHoc
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Tên lớp học không được để trống.")]
    public string TenLopHoc { get; set; }

    [Required(ErrorMessage = "Năm nhập học không được để trống.")]
    public int NamNhapHoc { get; set; }

    [Required(ErrorMessage = "Năm ra trường không được để trống.")]
    public int NamRaTruong { get; set; }

    public int SoLuongSinhVien { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
}
