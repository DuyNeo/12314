#pragma checksum "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f05b58728a5d1411682be2582630ff60e23712e"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.Donhang
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DonhangDetail/{id}")]
    public partial class DonhangDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chi tiet don hang</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-2\">Khách hàng </dt>\r\n        ");
            __builder.OpenElement(6, "dd");
            __builder.AddAttribute(7, "class", "col-sm-10");
            __builder.AddContent(8, 
#nullable restore
#line 14 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.KhachHang

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<dt class=\"col-sm-2\">Ngày đặt</dt>\r\n        ");
            __builder.OpenElement(11, "dd");
            __builder.AddAttribute(12, "class", "col-sm-10");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.NgayDat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        <dt class=\"col-sm-2\"></dt>\r\n        ");
            __builder.OpenElement(15, "dd");
            __builder.AddAttribute(16, "class", "col-sm-10");
            __builder.AddContent(17, 
#nullable restore
#line 22 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.NgayDat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<dt class=\"col-sm-2\">Tổng tiền</dt>\r\n        ");
            __builder.OpenElement(20, "dd");
            __builder.AddAttribute(21, "class", "col-sm-10");
            __builder.AddContent(22, 
#nullable restore
#line 26 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.Tongtien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<dt class=\"col-sm-2\">Trạng thái</dt>\r\n        ");
            __builder.OpenElement(25, "dd");
            __builder.AddAttribute(26, "class", "col-sm-10");
            __builder.AddContent(27, 
#nullable restore
#line 30 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.TrangthaiDonhang

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<dt class=\"col-sm-2\">Ghi chú</dt>\r\n        ");
            __builder.OpenElement(30, "dd");
            __builder.AddAttribute(31, "class", "col-sm-10");
            __builder.AddContent(32, 
#nullable restore
#line 34 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             model.Ghichu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table");
            __builder.AddMarkupContent(36, @"<thead><tr><th>
                    Món ăn
                </th>
                <th>
                    Hình
                </th>
                <th>
                    Số lượng
                </th>
                <th>
                    Thành tiền
                </th>
                <th>
                    Ghi chú
                </th></tr></thead>
        ");
            __builder.OpenElement(37, "tbody");
#nullable restore
#line 58 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
             foreach(var item in model.donHangChiTiets)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "tr");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 61 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
                     item.MonAn.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.AddMarkupContent(42, "<td><img style=\"width:150px\"></td>\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 65 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
                     item.SoLuong

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 66 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
                     item.ThanhTien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "<div><a class=\"btn btn-info\">Sua</a>\r\n    <a class=\"btn \">Danh sach</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDetail.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Tieude = "";
    public DonHang model;
    protected override void OnInitialized()
    {
        if(string.IsNullOrWhiteSpace(id) || id == "0")
        {
            navigation.NavigateTo("donhangList", true);
        }
        else
        {
            model = _donhangService.GetDonHang(int.Parse(id));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangService { get; set; }
    }
}
#pragma warning restore 1591
