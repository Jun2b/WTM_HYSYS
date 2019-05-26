using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInVMs
{
    public partial class StoreInSearcher : BaseSearcher
    {
        [Display(Name = "入库单号")]
        public String OrderSn { get; set; }
        [Display(Name = "入库日期")]
        public DateTime? DateIn { get; set; }
        public List<ComboSelectListItem> AllLocations { get; set; }
        [Display(Name = "库位名称")]
        public Guid? LocationId { get; set; }
        public List<ComboSelectListItem> AllSuppliers { get; set; }
        [Display(Name = "供应商名称")]
        public Guid? SupplierId { get; set; }
        [Display(Name = "确认状态")]
        public Boolean? isComfire { get; set; }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
            AllSuppliers = DC.Set<Supplier>().Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.SupplierName);
        }

    }
}
