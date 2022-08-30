using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ViewLogin
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}
public class ViewWebLogin
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}
public class ViewToken
{
    public string Token { get; set; }
    public string KhachhangId { get; set; }
    public string Email { get; set; }
}

