using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    
public class DonHang
{
    public enum TrangThaiDonHang
    {
        [Display(Name = "Mới đặt")]
        MoiDat = 1,
        [Display(Name = "Đang giao")]
        DangGiao = 2,
        [Display(Name = "Đã giao")]
        DaGiao = 3
    }
    [Key]

    public int DonHangID { get; set; }
    [ForeignKey("KhachHang")]
    public string KhachHangID { get; set; }
    //[DisplayFormat(DataFormatString = "{@:dd/MM/yyyy}")]
    [Required(ErrorMessage = "Bạn cần chọn ngày."), Display(Name = "Ngày đặt")]
    public DateTime NgayDat { get; set; }
    [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
    [Display(Name = "Tổng tiền")]
    public double Tongtien { get; set; }
    [Display(Name = "Trạng thái")]
    public TrangThaiDonHang TrangthaiDonhang { get; set; }
    [StringLength(250)]
    [Display(Name = "Ghi chú")]
    public string Ghichu { get; set; }
    public AppUser KhachHang { get; set; }
    public List<DonHangChiTiet> donHangChiTiets { get; set; }
    [StringLength(100)]
    [Display(Name = "Tên người nhận")]
    public string TenNguoiNhan { get; set; }
    [StringLength(100)]
    [Display(Name = "Địa chỉ")]
    public string Address { get; set; }
    [StringLength(10)]
    [Display(Name = "Số điện thoại")]
    public string SDT { get; set; }
}

