using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.BLL.InterfaceService
{
    public interface INhanVienBLL
    {
        string Add(NhanVien nhanVien);
        string Update(NhanVien nhanVien);
        string Delete(int id);
        List<NhanVien> GetAll(string TimKiem);
        NhanVien GetNhanVien(int id);
    }
}