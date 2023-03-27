using PHAMANHAO_TEST2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PHAMANHAO_TEST2.Controllers
{
    public class GioPhimController : Controller
    {
        // GET: GioPhim
        dbTest2DataContext data = new dbTest2DataContext();
        public List<Giophim> Laygiohang()
        {
            List<Giophim> lstGiohang = Session["GioPhim"] as List<Giophim>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<Giophim>();
                Session["GioPhim"] = lstGiohang;

            }
            return lstGiohang;
        }

        public ActionResult ThemGioHang(string malich, string strURL)
        {
            List<Giophim> lstGiohang = Laygiohang();
            Giophim sanpham = lstGiohang.Find(n => n.malich == malich);
            if (sanpham == null)
            {
                sanpham = new Giophim(malich);
                lstGiohang.Add(sanpham);
            }
            else
            {
                sanpham.isoLuong++;
            }

            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            if (Request.IsAjaxRequest())
            {
                return PartialView("GioHangPartial");
            }
            else
            {
                return Redirect(strURL);
            }
        }


        private int TongSoLuong()
        {
            int tsl = 0;
            List<Giophim> lstGiohang = Session["GioPhim"] as List<Giophim>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Sum(n => n.isoLuong);

            }
            return tsl;
        }
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
        private double TongTien()
        {
            double tt = 0;
            List<Giophim> lstGiohang = Session["GioPhim"] as List<Giophim>;
            if (lstGiohang != null)
            {
                tt = lstGiohang.Sum(n => n.dthanhtien);

            }
            return tt;
        }


        public ActionResult GioHang()
        {
            List<Giophim> lstGiohang = Laygiohang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }
        public ActionResult XoaGiohang(string malich)
        {
            List<Giophim> lstGiohang = Laygiohang();
            Giophim sanpham = lstGiohang.SingleOrDefault(n => n.malich == malich);
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.malich == malich);
                return RedirectToAction("GioHang");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult CapnhatGioHang(string malich, FormCollection collection)
        {
            List<Giophim> lstGiohang = Laygiohang();
            Giophim sanpham = lstGiohang.SingleOrDefault(n => n.malich == malich);
            if (sanpham != null)
            {
                sanpham.isoLuong = int.Parse(collection["txtSolg"].ToString());
            }
            return RedirectToAction("GioHang");

        }
        public ActionResult XoaTatCaGioHang()
        {
            List<Giophim> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("GioHang");
        }
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "User");
            }
            List<Giophim> listGioHang = Laygiohang();
            if (listGioHang.Count == 0)
            {
                return RedirectToAction("Home", "Home");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(listGioHang);
        }

        public ActionResult DatHang(FormCollection collection)
        {
            HoaDon dh = new HoaDon();
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            Phim s = new Phim();
            LichChieu lich = new LichChieu();
            List<Giophim> listGioHang = Laygiohang();
            dh.NgayMua = DateTime.Now;
            data.HoaDons.InsertOnSubmit(dh);
            data.SubmitChanges();
            foreach (var item in listGioHang)
            {
                ChiTiet ctdh = new ChiTiet();
                ctdh.mahd = dh.MaHD;
                ctdh.malich = item.malich;
                ctdh.soluong = item.isoLuong;
                lich = data.LichChieus.Single(n => n.malich == item.malich);
                lich.soluong -= ctdh.soluong;
                data.SubmitChanges();
                data.ChiTiets.InsertOnSubmit(ctdh);

            }
            data.SubmitChanges();

            Session["GioPhim"] = null;

            return RedirectToAction("XacnhanDonHang", "GioPhim");
        }

        public ActionResult XacnhanDonHang()
        {
            return View();
        }
    }
}