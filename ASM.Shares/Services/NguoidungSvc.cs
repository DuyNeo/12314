using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface INguoidungSvc
    {
        List<Nguoidung> GetNguoiDungAll();
        Nguoidung GetNguoiDung(int id);
        int AddNguoiDung(Nguoidung nguoidung);
        int EditNguoiDung(int id, Nguoidung nguoidung);
        Nguoidung Login(ViewLogin viewLogin);
    }
    public class NguoidungSvc : INguoidungSvc
    {
        protected DataContext _context;
        protected IMaHoaHelper _maHoaHelper;

    public NguoidungSvc(DataContext context, IMaHoaHelper maHoaHelper)
    {
        _context = context;
        _maHoaHelper = maHoaHelper;
    }

    public int AddNguoiDung(Nguoidung nguoidung)
        {

            int ret = 0;
            try
            {
                nguoidung.Password = _maHoaHelper.MaHoa(nguoidung.Password);
                _context.Add(nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;

        }

        public int EditNguoiDung(int id, Nguoidung nguoidung)
        {
            int ret = 0;
            try
            {
                Nguoidung _nguoidung = null;
                _nguoidung = _context.NguoiDungs.Find(id); //cách này chỉ dùng cho Khóa chính

                _nguoidung.UserName = nguoidung.UserName;
                _nguoidung.FullName = nguoidung.FullName;
                _nguoidung.Title = nguoidung.Title;
                _nguoidung.DOB = nguoidung.DOB;
                _nguoidung.Email = nguoidung.Email;
                _nguoidung.IsAdmin = nguoidung.IsAdmin;
                _nguoidung.Locked = nguoidung.Locked;
            if (nguoidung.Password != null)
            {
                nguoidung.Password = _maHoaHelper.MaHoa(nguoidung.Password);
                _nguoidung.Password = nguoidung.Password;
            }
            _context.Update(_nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoiDungId;
            }
            catch
            {
                ret = 0;
            }
            return ret;

        }

        public Nguoidung GetNguoiDung(int id)
        {
            Nguoidung nguoidung = null;
            nguoidung = _context.NguoiDungs.Find(id); //cách này chỉ dùng cho Khóa chính
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return nguoidung;

        }

        public List<Nguoidung> GetNguoiDungAll()
        {
            List<Nguoidung> nguoidungs = new List<Nguoidung>();
            nguoidungs = _context.NguoiDungs.ToList();
            return nguoidungs;
        }

        public Nguoidung Login(ViewLogin viewLogin)
        {
            var u = _context.NguoiDungs.Where(p => p.UserName.Equals(viewLogin.UserName) && p.Password.Equals(_maHoaHelper.MaHoa(viewLogin.Password))).FirstOrDefault();
            //var u = (from p in _context.NguoiDungs
            //        where p.UserName == viewLogin.UserName
            //        && p.Password == viewLogin.UserName
            //        select p).FirstOrDefault();
            return u;
        }
    }

