using QuanLyCuaHangXeMay.DAL.InterfaceService;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.DAL
{
    public class ChiTietHDBDAL : IChiTietHDBDAL
    {
        DBContext db = new DBContext();
        public int Add(ChiTietHDB chiTietHDB)
        {
           db.ChiTietHDBs.Add(chiTietHDB);
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            db.ChiTietHDBs.Remove(GetChiTietHDB(id));
            return db.SaveChanges();
        }

        public List<getChiTietHoaDonBan_Result> GetAll(int idHDB)
        {
            return db.getChiTietHoaDonBan(idHDB).ToList();
        }

        public ChiTietHDB GetChiTietHDB(int id)
        {
            return db.ChiTietHDBs.Find(id);
        }
    }
}
