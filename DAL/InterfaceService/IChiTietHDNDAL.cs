using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.DAL.InterfaceService
{
    public interface IChiTietHDNDAL
    {
        int Add(ChiTietHDN chiTietHoaDonNhap);
        int Delete(int id);
        List<GetChiTietHoaDonNhap_Result> GetAll(int idHDN);
        ChiTietHDN GetCTHDN(int id);
    }
}
