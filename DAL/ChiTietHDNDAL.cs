using QuanLyCuaHangXeMay.DAL.InterfaceService;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.DAL
{
    public class ChiTietHDNDAL : IChiTietHDNDAL
    {
        DBContext db = new DBContext();
        public int Add(ChiTietHDN chiTietHoaDonNhap)
        {
            db.ChiTietHDNs.Add(chiTietHoaDonNhap);
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            db.ChiTietHDNs.Remove(GetCTHDN(id));
            return db.SaveChanges();
        }

        public List<GetChiTietHoaDonNhap_Result> GetAll(int idHDN)
        {
            return db.GetChiTietHoaDonNhap(idHDN).ToList();
        }

     

        public ChiTietHDN GetCTHDN(int id)
        {
            return db.ChiTietHDNs.Find(id);
        }

  
    }
}
