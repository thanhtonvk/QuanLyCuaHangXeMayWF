using System.Collections.Generic;
using Entity;

namespace QuanLyCuaHangXeMay.DAL.InterfaceService
{
    public interface IHoaDonNhapDAL
    {
        int Add(HoaDonNhap hoaDonNhap);
        int Update(HoaDonNhap hoaDonNhap);
        int Delete(int id);
        List<GetHoaDonNhap_Result> GetAll();
        HoaDonNhap GetHoaDonNhap(int id);
    }
}