using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInPriceVMs
{
    public partial class StoreInPriceSearcher : BaseSearcher
    {
        [Display(Name = "入库日期")]
        public DateTime? DateIn { get; set; }

        protected override void InitVM()
        {
        }

    }
}
