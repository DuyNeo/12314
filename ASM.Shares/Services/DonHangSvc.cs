using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IDonHangSvc
    {
        List<DonHang> GetDonHangAll();
        List<DonHang> GetDonHangByKhachHang(string khachHangID);
        DonHang GetDonHang(int id);
        int AddDonHang(DonHang donHang);
        int EditDonHang(int id, DonHang donHang);
    }
    public class DonHangSvc : IDonHangSvc
    {
        protected DataContext _context;

        public DonHangSvc(DataContext context)
        {
            _context = context;
        }

        public int AddDonHang(DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Add(donHang);
                _context.SaveChanges();
                ret = donHang.DonHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditDonHang(int id, DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Update(donHang);
                _context.SaveChanges();
                ret = donHang.DonHangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public DonHang GetDonHang(int id)
        {
            DonHang donHang = null;
            donHang = _context.DonHangs.Where(x => x.DonHangID == id)
                .Include(x => x.KhachHang)
                .Include(x => x.donHangChiTiets)
                .ThenInclude(y => y.MonAn)
                .FirstOrDefault();
            return donHang;
        }

        public List<DonHang> GetDonHangAll()
        {
            List<DonHang> donHangs = new List<DonHang>();
            donHangs = _context.DonHangs.OrderByDescending(x => x.NgayDat).Include(x => x.KhachHang)
                .Include(x => x.donHangChiTiets)
                .ToList();
            return donHangs;
        }

        public List<DonHang> GetDonHangByKhachHang(string khachHangID)
        {
            List<DonHang> donHangs = new List<DonHang>();
            donHangs = _context.DonHangs.Where(x=>x.KhachHangID==khachHangID).OrderByDescending(x => x.NgayDat).Include(x => x.KhachHang)
                .Include(x => x.donHangChiTiets)
                .ToList();
            return donHangs;
        }
    }

