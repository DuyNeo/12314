using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class KhachHang
    {
        [Key]
        public int KhachHangID { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Bạn cần nhập họ tên.")]
        [Display(Name ="Họ & Tên")]
        [Column(TypeName = "nvarchar(150)")]
        public string FullName { get; set; }
        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NgaySinh { get; set; }
        [Required(ErrorMessage ="Bạn cần nhập số điện thoại."),Display(Name ="Số phone")]
        [Column(TypeName ="varchar(15)"),MaxLength(15)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$",ErrorMessage ="Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [Required]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        public string FacebookLink { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [StringLength(250)]
        [Display(Name ="Mô tả")]
        public string Mota { get; set; }
    }

