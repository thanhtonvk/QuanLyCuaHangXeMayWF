﻿using QuanLyCuaHangXeMay.BLL.InterfaceService;
using QuanLyCuaHangXeMay.DAL;
using QuanLyCuaHangXeMay.DAL.InterfaceService;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.BLL
{
    public class ChiTietHDNBLL : IChiTietHDNBLL
    {
        IChiTietHDNDAL dal = new ChiTietHDNDAL();
        public string Add(ChiTietHDN chiTietHoaDonNhap)
        {
            int rs = dal.Add(chiTietHoaDonNhap);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public string Delete(int id)
        {
            int rs = dal.Delete(id);
            if (rs > 0) return "Thành công";
            return "Thất bại";
        }

        public List<GetChiTietHoaDonNhap_Result> GetAll(int idHDN)
        {
            return dal.GetAll(idHDN);   
        }

        public ChiTietHDN GetCTHDN(int id)
        {
            return dal.GetCTHDN(id);
        }
    }
}
