using System;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;

namespace HYSYS.Models
{
    public class StoreInPrice:BasePoco
    {
        [Display(Name = "所属公司")]
        [Required()]
        public Guid? CompanyId { get; set; }
        
        [Display(Name = "入库日期")]
        public DateTime DateIn { get; set; }

        //各种规格
        //母蟹规格
        [Display(Name = "中母")]
        public float m10p { get; set; }
        [Display(Name = "1.8母")]
        public float m18p { get; set; }
        [Display(Name = "2母")]
        public float m20p { get; set; }
        [Display(Name = "2.5母")]
        public float m25p { get; set; }
        [Display(Name = "2.8母")]
        public float m28p { get; set; }
        [Display(Name = "3母")]
        public float m30p { get; set; }
        [Display(Name = "3.5母")]
        public float m35p { get; set; }
        [Display(Name = "4母")]
        public float m40p { get; set; }
        [Display(Name = "5母")]
        public float m50p { get; set; }
        //公蟹
        [Display(Name = "中公")]
        public float g10p { get; set; }
        [Display(Name = "2公")]
        public float g20p { get; set; }
        [Display(Name = "2.5公")]
        public float g25p { get; set; }
        [Display(Name = "3公")]
        public float g30p { get; set; }
        [Display(Name = "3.5公")]
        public float g35p { get; set; }
        [Display(Name = "4公")]
        public float g40p { get; set; }
        [Display(Name = "4.5公")]
        public float g45p { get; set; }
        [Display(Name = "5公")]
        public float g50p { get; set; }
        [Display(Name = "6公")]
        public float g60p { get; set; }
        [Display(Name = "7公")]
        public float g70p { get; set; }
        [Display(Name = "8公")]
        public float g80p { get; set; }
        //
    }
}