using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IDonHangChiTietSVC
    {
        int AddDonHangChitietSvc(DonHangChiTiet donHangChiTiet);
    }
    public class DonHangChiTietSVC: IDonHangChiTietSVC
    {
        protected DataContext _context;

        public DonHangChiTietSVC(DataContext context)
        {
            _context = context;
        }

        public int AddDonHangChitietSvc(DonHangChiTiet donHangChiTiet)
        {
            int ret = 0;
            try
            {
                _context.Add(donHangChiTiet);
                _context.SaveChanges();
                ret = donHangChiTiet.ChiTietID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }

