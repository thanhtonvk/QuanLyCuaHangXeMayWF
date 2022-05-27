﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.BLL.InterfaceService
{
    public interface IChiTietHDNBLL
    {
        string Add(ChiTietHDN chiTietHoaDonNhap);
        string Delete(int id);
        List<GetChiTietHoaDonNhap_Result> GetAll(int idHDN);
        ChiTietHDN GetCTHDN(int id);
    }
}
