using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelClasses; // Model sınıflarını kullanmak için gerekli

namespace PersonelTakipSistemi.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KullaniciController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Kullanıcıları ve ilgili UretimHareketiBars verilerini çekme
            var items = await _context.spurtuser
                .Include(u => u.UretimHareketiBars) // İlişkili verileri dahil et
                .ToListAsync(); // ToListAsync doğru metod

            return View(items);
        }
    }
}
