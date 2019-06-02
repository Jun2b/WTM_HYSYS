using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreOutVMs
{
    public partial class StoreOutSearcher : BaseSearcher
    {
        [Display(Name = "出库单号")]
        public String OrderSn { get; set; }
        [Display(Name = "出库日期")]
        public DateTime? DateOut { get; set; }
        public List<ComboSelectListItem> AllLocations { get; set; }
        [Display(Name = "库位名称")]
        public Guid? LocationId { get; set; }
        public List<ComboSelectListItem> AllCustomers { get; set; }
        [Display(Name = "供应商名称")]
        public Guid? CustomerId { get; set; }
        [Display(Name = "确认状态")]
        public Boolean? isComfire { get; set; }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
            AllCustomers = DC.Set<Customer>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CustomerName);
        }

    }
}
