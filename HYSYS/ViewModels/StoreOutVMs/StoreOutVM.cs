using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;
using HYSYS.ViewModels.CustomerVMs;


namespace HYSYS.ViewModels.StoreOutVMs
{
    public partial class StoreOutVM : BaseCRUDVM<StoreOut>
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        //public List<ComboSelectListItem> AllCustomers { get; set; }
        public CustomerListVM SelcetCustomerListVm { get; set; }

        public StoreOutVM()
        {
            SelcetCustomerListVm=new CustomerListVM();
            SetInclude(x => x.Location);
            SetInclude(x => x.Customer);
        }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
            //AllCustomers = DC.Set<Customer>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CustomerName);
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
        public void GenerateSn()
        {
            var now = DateTime.Now.ToString("yyyyMMddHHmm");
            var companycode = LoginUserInfo.Attributes["CompanyCode"].ToString();
            Entity.OrderSn = companycode + now;
        }
    }
}
