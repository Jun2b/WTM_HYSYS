using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.ReStockVMs
{
    public partial class ReStockSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        [Display(Name = "仓库库位")]
        public Guid? LocationId { get; set; }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
        }

    }
}
