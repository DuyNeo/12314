using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class Nguoidung
    {
        [Key]
        public int NguoiDungId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Tài khoản")]
        [Required(ErrorMessage ="Bạn cần nhập tài khoản.")]
        public string UserName { get; set; }
        [Display(Name ="Họ tên")]
        [Required(ErrorMessage = "Bạn cần nhập họ tên.")]
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Required]
        [RegularExpression("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        [Display(Name ="Chức danh")]
        [Column(TypeName ="nvarchar(100)")]
        public string Title { get; set; }
        [Display(Name ="Ngày sinh")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }//date of birth
        [Display(Name ="Quản trị")]
        public bool IsAdmin { get; set; }
        [Display(Name = "Đang sử dụng")]
        public bool Locked { get; set; }
        [Column(TypeName = "varchar(50)"),MaxLength(50)]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Mật khẩu không khớp")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
