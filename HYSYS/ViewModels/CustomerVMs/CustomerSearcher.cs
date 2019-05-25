using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.CustomerVMs
{
    public partial class CustomerSearcher : BaseSearcher
    {
        [Display(Name = "客户编码")]
        public String CustomerCode { get; set; }
        [Display(Name = "客户名称")]
        public String CustomerName { get; set; }
        [Display(Name = "联系方式")]
        public String PhoneNumber { get; set; }

        protected override void InitVM()
        {
        }

    }
}
