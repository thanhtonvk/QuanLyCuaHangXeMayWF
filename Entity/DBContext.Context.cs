//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public DbSet<DaiLy> DaiLies { get; set; }
        public DbSet<HoaDonBan> HoaDonBans { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    
        public virtual ObjectResult<getChiTietHoaDonBan_Result> getChiTietHoaDonBan(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("MaHD", maHD) :
                new ObjectParameter("MaHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getChiTietHoaDonBan_Result>("getChiTietHoaDonBan", maHDParameter);
        }
    
        public virtual ObjectResult<GetChiTietHoaDonNhap_Result> GetChiTietHoaDonNhap(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("MaHD", maHD) :
                new ObjectParameter("MaHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetChiTietHoaDonNhap_Result>("GetChiTietHoaDonNhap", maHDParameter);
        }
    
        public virtual ObjectResult<GetHoaDonBan_Result> GetHoaDonBan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHoaDonBan_Result>("GetHoaDonBan");
        }
    
        public virtual ObjectResult<GetHoaDonNhap_Result> GetHoaDonNhap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHoaDonNhap_Result>("GetHoaDonNhap");
        }
    }
}
