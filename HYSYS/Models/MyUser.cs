using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    [Table("FrameworkUsers")]
    public class MyUser:FrameworkUserBase
    {
        [Display(Name = "所属公司")]
        [Required()]
        public Guid? CompanyId { get; set; }
        [Display(Name = "所属公司")]
        public Company Company { get; set; }
    }
}