using BaiKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel taiKhoan)
        {
            if (taiKhoan != null && taiKhoan.MatKhau != null && (taiKhoan.MatKhau).Length > 0)
            {
                taiKhoan.MatKhau = taiKhoan.MatKhau + "_chuoi_ma_hoa";
            }

            return View(taiKhoan);
        }
    }
}
