using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BaiKiemTra03_02.Models;
using BaiKiemTra03_02.Data;

public class SachController : Controller
{
    private readonly ApplicationDbContext _db;

    public SachController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var sach = _db.Sach.ToList();
        ViewBag.Sach = sach;
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Sach sach)
    {
        if (ModelState.IsValid)
        {
            _db.Sach.Add(sach);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        var sach = _db.Sach.Find(id);
        return View(sach);
    }

    [HttpPost]
    public IActionResult Edit(Sach sach)
    {
        if (ModelState.IsValid)
        {
            _db.Sach.Update(sach);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        var sach = _db.Sach.Find(id);
        return View(sach);
    }

    [HttpPost]
    public IActionResult DeleteConfirm(int id)
    {
        var sach = _db.Sach.Find(id);
        if (sach == null)
        {
            return NotFound();
        }
        _db.Sach.Remove(sach);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Detail(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        var sach = _db.Sach.Find(id);
        return View(sach);
    }

    [HttpGet]
    public IActionResult Search(string searchString)
    {
        if (!string.IsNullOrEmpty(searchString))
        {
            var sach = _db.Sach.Where(s => s.TieuDeSach.Contains(searchString)).ToList();
            ViewBag.SearchString = searchString;
            ViewBag.Sach = sach;
        }
        else
        {
            var sach = _db.Sach.ToList();
            ViewBag.Sach = sach;
        }
        return View("Index");
    }
}
