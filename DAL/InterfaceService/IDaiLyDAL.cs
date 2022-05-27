using System.Collections.Generic;
using QuanLyCuaHangXeMay.Models;

namespace QuanLyCuaHangXeMay.DAL.InterfaceService
{
    public interface IDaiLyDAL
    {
        int Add(DaiLy daiLy);
        int Update(DaiLy daiLy);
        int Delete(int id);
        List<DaiLy> GetAll();
        DaiLy GetDaiLy(int id);
    }
}