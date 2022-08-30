using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PostCartModel
{
    public string khachHangId { get; set; }
    public double TongTien { get; set; }    
    public int quantity { set; get; }
    public MonAn product { set; get; }
    public string ghiChu { get; set; }
    public string tenNguoiNhan { get;set; }
    public string address { get; set; } 
    public string phoneNumber { set; get; }
    public List<CartItem> cartItems { get; set; }
}
