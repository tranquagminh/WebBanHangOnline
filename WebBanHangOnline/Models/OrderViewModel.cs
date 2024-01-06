using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên khách hàng không để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại này không để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ này không để trống")]
        public string Address { get; set; }
        public int TypePayment { get; set; }
    }
}