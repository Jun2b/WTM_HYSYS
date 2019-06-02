using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    public class Supplier:BasePoco
    {
        [Display(Name = "供应商编码")]
        [Required(ErrorMessage = "{0}是必填项")]
        [StringLength(5)]
        public string SupplierCode { get; set; }

        [Display(Name = "供应商名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string SupplierName { get; set; }

        [Display(Name = "联系方式")]
        public string PhoneNumber { get; set; }

        [Display(Name = "本公司名称")]
        [Required()]
        public Guid? CompanyId { get; set; }
        //[Display(Name = "本公司名称")]
        //public Company Company { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}