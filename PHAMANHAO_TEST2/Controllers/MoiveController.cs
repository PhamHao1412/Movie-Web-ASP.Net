using PHAMANHAO_TEST2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PHAMANHAO_TEST2.Controllers
{
    public class MoiveController : Controller
    {
        // GET: Moive
        public int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<Giophim> lstGiohang = Session["GioPhim"] as List<Giophim>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Count;
            }
            return tsl;

        }
        dbTest2DataContext data = new dbTest2DataContext();
        public ActionResult Index()
        {
           var all_item = from d in data.Phims select d;
            return View(all_item);
        }
        
        public ActionResult LichChieu()
        {
            var all_item = from d in data.LichChieus select d;
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();

            return View(all_item);
        }
        public ActionResult PhimDangChieu()
        {
            var result = from p in data.Phims
                         where p.ngaychieu <= DateTime.Now
                         select p;
            return View(result);
        }
        public ActionResult PhimSapChieu()
        {
            var result = from p in data.Phims
                         where p.ngaychieu > DateTime.Now
                         select p;
            return View(result);
        }
        public ActionResult ThongKe()
        {
            var result = from p in data.Phims
                         join l in data.LichChieus on p.maphim equals l.maphim
                         join c in data.ChiTiets on l.malich equals c.malich
                         group c by p.tenphim into g
                         select new ThongKeViewModel
                         {
                             Ten = g.Key,
                             TongSoLuong =(int) g.Sum(x => x.soluong)
                         };
            return View(result);
        }
        public ActionResult ThongKeDoanhThu()
        {
            var result = from c in data.ChiTiets
                         join l in data.LichChieus on c.malich equals l.malich
                         join p in data.Phims on l.maphim equals p.maphim
                         group new { l.maphim, p.tenphim, c.soluong, l.gia } by new { l.maphim, p.tenphim } into g
                         select new ThongKeViewModel
                         {
                             Ten = g.Key.tenphim,
                             TongSoLuong = (int)g.Sum(x => x.gia * x.soluong)
                         };

            return View(result) ;
        }
    }
}