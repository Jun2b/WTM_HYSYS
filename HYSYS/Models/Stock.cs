using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    public class Stock:BasePoco
    {
        [Display(Name = "所属公司")]
        [Required()]
        public Guid? CompanyId { get; set; }
        [Display(Name = "仓库库位")]
        public Location Location { get; set; }

        [Display(Name = "仓库库位")]
        [Required()]
        public Guid? LocationId { get; set; }

        //各种规格
        //母蟹规格
        [Display(Name = "中母")]
        public float m10 { get; set; }
        [Display(Name = "1.8母")]
        public float m18 { get; set; }
        [Display(Name = "2母")]
        public float m20 { get; set; }
        [Display(Name = "2.5母")]
        public float m25 { get; set; }
        [Display(Name = "2.8母")]
        public float m28 { get; set; }
        [Display(Name = "3母")]
        public float m30 { get; set; }
        [Display(Name = "3.5母")]
        public float m35 { get; set; }
        [Display(Name = "4母")]
        public float m40 { get; set; }
        [Display(Name = "5母")]
        public float m50 { get; set; }
        //公蟹
        [Display(Name = "中公")]
        public float g10 { get; set; }
        [Display(Name = "2公")]
        public float g20 { get; set; }
        [Display(Name = "2.5公")]
        public float g25 { get; set; }
        [Display(Name = "3公")]
        public float g30 { get; set; }
        [Display(Name = "3.5公")]
        public float g35 { get; set; }
        [Display(Name = "4公")]
        public float g40 { get; set; }
        [Display(Name = "4.5公")]
        public float g45 { get; set; }
        [Display(Name = "5公")]
        public float g50 { get; set; }
        [Display(Name = "6公")]
        public float g60 { get; set; }
        [Display(Name = "7公")]
        public float g70 { get; set; }
        [Display(Name = "8公")]
        public float g80 { get; set; }


    }
}