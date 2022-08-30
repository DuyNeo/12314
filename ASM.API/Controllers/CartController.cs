using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.API.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public CartController(IDonHangSvc donHangSvc, IDonHangChiTietSVC donHangChiTietSVC, DataContext dataContext)
        {
            _DonHangSvc = donHangSvc;
            _DonHangChiTietSVC = donHangChiTietSVC;
            _context = dataContext;
        }

        public IDonHangSvc _DonHangSvc { get; }
        public IDonHangChiTietSVC _DonHangChiTietSVC { get; }
        public DataContext _context { get; }
        [HttpPost]

        public async Task<ActionResult<int>> PostCart(PostCartModel giohang)
        {
            try
            {
                var cart = giohang.cartItems;
                decimal total = 0;
                foreach (var item in cart)
                {
                    var thanhtien = item.quantity * item.product.Gia;
                    total += thanhtien;
                }

                DonHang donHang = new DonHang()
                {
                    KhachHangID = giohang.khachHangId,
                    Ghichu = giohang.ghiChu,
                    TenNguoiNhan = giohang.tenNguoiNhan,
                    Address = giohang.address,
                    SDT = giohang.phoneNumber,
                    NgayDat = DateTime.Now.Date,
                    Tongtien = (double)total,
                    TrangthaiDonhang = DonHang.TrangThaiDonHang.MoiDat,
                    KhachHang = _context.Users.Where(u => u.Id == giohang.khachHangId).FirstOrDefault()
            };
                await _context.DonHangs.AddAsync(donHang);
                await _context.SaveChangesAsync();
                for (int i = 0; i < cart.Count; i++)
                {
                    DonHangChiTiet detail = new DonHangChiTiet()
                    {
                        DonHangID = _context.DonHangs.Max(x => x.DonHangID),
                        MonAnID = cart[i].product.Id,
                        SoLuong = cart[i].quantity,
                        ThanhTien = cart[i].quantity * (double)cart[i].product.Gia
                    };
                    var product = _context.MonAns
                                .Where(p => p.Id == cart[i].product.Id && p.TrangThai == true)
                                .FirstOrDefault();
                    if (product.Quantity > 0)
                    {
                        product.Quantity -= cart[i].quantity;
                    }
                    _context.MonAns.Update(product);
                    await _context.DonHangChiTiets.AddAsync(detail);
                    await _context.SaveChangesAsync();
                }
            }
            catch
            {
                return BadRequest(-1);
            }

            return Ok(1);

        }
    }
}
