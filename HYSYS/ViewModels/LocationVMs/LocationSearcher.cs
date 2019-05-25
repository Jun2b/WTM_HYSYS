using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.LocationVMs
{
    public partial class LocationSearcher : BaseSearcher
    {
        [Display(Name = "仓库编码")]
        public String LocationCode { get; set; }
        [Display(Name = "仓库名称")]
        public String LocationName { get; set; }

        protected override void InitVM()
        {
        }

    }
}
