using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.BLL.InterfaceService
{
    public interface ISanPhamBLL
    {
        string Add(SanPham sanPham);
        string Update(SanPham sanPham);
        string Delete(int id);
        List<SanPham> GetAll(string TimKiem);
        SanPham GetSanPham(int id);
    }
}
