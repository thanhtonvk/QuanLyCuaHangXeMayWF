﻿using QuanLyCuaHangXeMay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangXeMay.DAL.InterfaceService
{
    internal interface IChiTietHDBDAL
    {
        int Add(ChiTietHDB chiTietHDB);
        int Delete(int id);
        List<getChiTietHoaDonBan_Result> GetAll(int idHDB);
        ChiTietHDB GetChiTietHDB(int id);
    }
}
