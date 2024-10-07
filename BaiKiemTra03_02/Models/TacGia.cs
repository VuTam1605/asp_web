using System.ComponentModel.DataAnnotations;

public class TacGia
{
    [Key]
    public int MaTacGia { get; set; }

    [Required(ErrorMessage = "Tên tác giả không được để trống.")]
    public string TenTacGia { get; set; }

    [Required(ErrorMessage = "Quốc tịch không được để trống.")]
    public string QuocTich { get; set; }

    [Required(ErrorMessage = "Năm sinh không được để trống.")]
    public int NamSinh { get; set; } // Kiểu int cho năm sinh

    public DateTime DateCreated { get; set; } = DateTime.Now;
}
