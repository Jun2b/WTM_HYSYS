using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.CompanyVMs
{
    public partial class CompanySearcher : BaseSearcher
    {
        [Display(Name = "公司编码")]
        public String CompanyCode { get; set; }
        [Display(Name = "公司名称")]
        public String CompanyName { get; set; }

        protected override void InitVM()
        {
        }

    }
}
