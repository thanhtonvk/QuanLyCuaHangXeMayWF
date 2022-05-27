using System.Collections.Generic;
using QuanLyCuaHangXeMay.Models;

namespace QuanLyCuaHangXeMay.DAL.InterfaceService
{
    public interface ILoaiSanPhamDAL
    {
        int Add(LoaiSanPham loaiSanPham);
        int Update(LoaiSanPham loaiSanPham);
        int Delete(int id);
        List<LoaiSanPham> GetAll();
        LoaiSanPham GetLoaiSanPham(int id);
    }
}