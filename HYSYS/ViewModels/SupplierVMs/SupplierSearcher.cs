using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.SupplierVMs
{
    public partial class SupplierSearcher : BaseSearcher
    {
        [Display(Name = "供应商编码")]
        public String SupplierCode { get; set; }
        [Display(Name = "供应商名称")]
        public String SupplierName { get; set; }
        [Display(Name = "联系方式")]
        public String PhoneNumber { get; set; }

        protected override void InitVM()
        {
        }

    }
}
