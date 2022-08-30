using System.Collections.Generic;
using System.Linq;


public interface IKhachHangSvc
    {
        List<AppUser> GetKhachHangAll();
        AppUser GetKhachHang(string khachHangID);
        string AddKhachHang(AppUser KhachHang);
        string EditKhachHang(string id, AppUser KhachHang);
        KhachHang Login(ViewWebLogin viewLogin);
    }
    public class KhachHangSvc : IKhachHangSvc
    {
        protected DataContext _context;
        protected IMaHoaHelper _maHoaHelper;

        public KhachHangSvc(DataContext context, IMaHoaHelper maHoaHelper)
        {
            _context = context;
            _maHoaHelper = maHoaHelper;
        }

        public string AddKhachHang(AppUser KhachHang)
        {
            string ret = "";
            try
            {
                KhachHang.PasswordHash = KhachHang.PasswordHash;
                _context.Add(KhachHang);
                _context.SaveChanges();
                ret = KhachHang.Id;
            }
            catch
            {
                ret = "";
            }
            return ret;
        }

        public string EditKhachHang(string id, AppUser KhachHang)
        {
            string ret = "";
            try
            {
                AppUser _khachHang = null;
                _khachHang = _context.Users.Find(id);
                _khachHang.UserName = KhachHang.UserName;
                _khachHang.DayOfBirth = KhachHang.DayOfBirth;
                _khachHang.PhoneNumber = KhachHang.PhoneNumber;
                _khachHang.Email = KhachHang.Email;
                //if (_khachHang.PasswordHash != null)
                //{
                //    KhachHang.PasswordHash = KhachHang.PasswordHash;
                //    _khachHang.PasswordHash = KhachHang.PasswordHash;
                  
                //}
          
                _context.Update(_khachHang);
                _context.SaveChanges();
                ret = _khachHang.Id;
            }
            catch
            {
                ret = "";
            }
            return ret;
        }

        public AppUser GetKhachHang(string khachHangID)
        {
            return _context.Users.Find(khachHangID);
        }

        public List<AppUser> GetKhachHangAll()
        {
            return _context.Users.ToList();
        }

        public KhachHang Login(ViewWebLogin viewLogin)
        {
            return _context.KhachHangs.Where(p => p.Email.Equals(viewLogin.Email) && p.Password.Equals(_maHoaHelper.MaHoa(viewLogin.Password))).FirstOrDefault();
        }
    }

