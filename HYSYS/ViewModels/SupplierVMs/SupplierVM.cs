using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.SupplierVMs
{
    public partial class SupplierVM : BaseCRUDVM<Supplier>
    {
        //public List<ComboSelectListItem> AllCompanys { get; set; }

        public SupplierVM()
        {
            //SetInclude(x => x.Company);
        }

        protected override void InitVM()
        {
            //AllCompanys = DC.Set<Company>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

        public override void DoAdd()
        {
            Entity.CompanyId = new Guid(LoginUserInfo.Attributes["CompanyId"].ToString());
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
