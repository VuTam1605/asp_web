using BT06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT06.Controllers
{
    public class TaiKhoanController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangNhap(TaiKhoanViewModel TaiKhoan)
        {
            if (TaiKhoan != null && TaiKhoan.Password != null && (TaiKhoan.Password).Length > 0)
            {
                TaiKhoan.Password = TaiKhoan.Password + "_chuoi_ma_hoa";
            }

            return View(TaiKhoan);
        }
    }
}
