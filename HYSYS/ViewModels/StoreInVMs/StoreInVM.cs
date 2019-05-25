using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInVMs
{
    public partial class StoreInVM : BaseCRUDVM<StoreIn>
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        public List<ComboSelectListItem> AllSuppliers { get; set; }

        public StoreInVM()
        {
            SetInclude(x => x.Location);
            SetInclude(x => x.Supplier);
        }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null,y => y.LocationName);
            AllSuppliers = DC.Set<Supplier>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.SupplierName);
        }

        public override void DoAdd()
        {
            Entity.CompanyId = new Guid(LoginUserInfo.Attributes["CompanyId"].ToString());
            Entity.isComfire = false;
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
