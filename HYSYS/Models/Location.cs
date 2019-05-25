using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    public class Location:BasePoco
    {

        [Display(Name = "仓库编码")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string LocationCode { get; set; }
        [Display(Name = "仓库名称")]
        [StringLength(50, ErrorMessage = "{0}最多输入{1}个字符")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string LocationName { get; set; }
        [Display(Name = "所属公司")]
        [Required()]
        public Guid? CompanyId { get; set; }
        //[Display(Name = "所属公司")]
        //public Company Company { get; set; }

        [Display(Name = "备注")]
        public string Remark { get; set; }
        
    }
}