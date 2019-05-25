using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    public class Customer:BasePoco
    {
        [Display(Name = "客户编码")]
        public string CustomerCode { get; set; }

        [Display(Name = "客户名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string CustomerName { get; set; }

        [Display(Name = "联系方式")]
        public string PhoneNumber { get; set; }

        [Display(Name = "所属公司")]
        [Required()]
        public Guid? CompanyId { get; set; }
        [Display(Name = "所属公司")]
        public Company Company { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }

    }
}