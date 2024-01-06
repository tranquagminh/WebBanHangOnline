using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Order")]
    public class Order : CommonAbstract
    {
        public Order() { 
            this.Details = new HashSet<OrderDetail>();
        }  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Số điện thoại này không để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ này không để trống")]
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int TypePayment { get; set; }

        public ICollection<OrderDetail> Details { get; set; }
    }
}