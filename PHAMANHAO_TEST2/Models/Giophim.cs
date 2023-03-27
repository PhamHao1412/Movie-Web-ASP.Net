using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml.Linq;

namespace PHAMANHAO_TEST2.Models
{
    public class Giophim
    {
        dbTest2DataContext data = new dbTest2DataContext();
        [Display(Name = "Mã lịch chiếu")]
        public string malich { get; set; }
        [Display(Name = "Mã")]
        public int ma { get; set; }
        [Display(Name = "Giá bán")]
        public Double gia { get; set; }
        [Display(Name = "Số lượng")]
        public int isoLuong { get; set; }
        [Display(Name = "Thành tiền")]
        public Double dthanhtien
        {   
            get { return isoLuong * gia; }
        }
        public Giophim(string malich)
        {
            this.malich = malich;
            LichChieu lc = data.LichChieus.Single(n => n.malich == malich);
            ma =(int) lc.maphim;
            gia = (int)lc.gia;
            isoLuong = 1;
        }
    }
}