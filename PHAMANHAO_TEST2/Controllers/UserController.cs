using PHAMANHAO_TEST2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PHAMANHAO_TEST2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        dbTest2DataContext data = new dbTest2DataContext();
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KhachHang khachhang)
        {

            var hoten = collection["hoten"];
            var matkhau = collection["matkhau"];
            var diachi = collection["diachi"];
            var dienthoai = collection["dienthoai"];
            if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";

            }
            else
            {
                if (!matkhau.Equals(matkhau))
                {
                    ViewData["MatKhauGiongNhau"] = "Mật khẩu và mật khảu xác nhận phải giống nhau;";
                }
                else
                {

                    khachhang.hoten = hoten;
                    khachhang.matkhau = matkhau;
                    khachhang.diachi = diachi;
                    khachhang.dienthoai = dienthoai;
                    data.KhachHangs.InsertOnSubmit(khachhang);
                    data.SubmitChanges();
                    return RedirectToAction("DangNhap");
                }
            }
            return this.DangKy();

        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {

            var dienthoai = collection["dienthoai"];
            var matkhau = collection["matkhau"];
            KhachHang khachhang = data.KhachHangs.SingleOrDefault(n => n.dienthoai == dienthoai && n.matkhau == matkhau);
            if (khachhang != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TaiKhoan"] = khachhang;
                return RedirectToAction("Index", "Moive");
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                return this.DangNhap();
            }

        }
    }
}
    
