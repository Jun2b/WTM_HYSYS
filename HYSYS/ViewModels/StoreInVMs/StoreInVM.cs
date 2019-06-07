using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HYSYS.Controllers;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;
using HYSYS.ViewModels.ReStockVMs;
using HYSYS.ViewModels.StockVMs;
using HYSYS.ViewModels.StoreInPriceVMs;
using HYSYS.ViewModels.StoreOutVMs;
using HYSYS.ViewModels.SupplierVMs;
using Microsoft.EntityFrameworkCore;


namespace HYSYS.ViewModels.StoreInVMs
{
    public partial class StoreInVM : BaseCRUDVM<StoreIn>
    {
        public List<ComboSelectListItem> AllLocations { get; set; }
        //public List<ComboSelectListItem> AllSuppliers { get; set; }
        

        public SupplierListVM SelcetSupplierListVm { get; set; }


        public StoreInPrice TodayPrice { get; set; }

        public StoreInVM()
        {
            SelcetSupplierListVm=new SupplierListVM();
            SetInclude(x => x.Location);
            SetInclude(x => x.Supplier);
        }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).GetSelectListItems(LoginUserInfo.DataPrivileges, null,y => y.LocationName);
            //AllSuppliers = DC.Set<Supplier>().Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.SupplierName);
            //SelcetSupplierListVm.DoInitListVM();

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
            var companycode=LoginUserInfo.Attributes["CompanyCode"].ToString();
            Entity.OrderSn = companycode + now;
        }

        public void DoComfire()
        {
            //APIHelper.CallAPI()
            ////DC.RunSP("UpdateStock", Entity.ID);
         
            Entity.isComfire = true;
            DoEdit();
            var oldStock = DC.Set<Stock>().AsNoTracking().Where(x =>
                x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()) &&
                x.LocationId == Entity.LocationId).SingleOrDefault();
            var vml = new StockVM();
            vml.CopyContext(this);
            if (oldStock == null)
            {
                
                vml.Entity.CompanyId = Entity.CompanyId;
                vml.Entity.LocationId = Entity.LocationId;
                vml.Entity.m10 = Entity.m10;
                vml.Entity.m18 = Entity.m18;
                vml.Entity.m20 = Entity.m20;
                vml.Entity.m25 = Entity.m25;
                vml.Entity.m28 = Entity.m28;
                vml.Entity.m30 = Entity.m30;
                vml.Entity.m35 = Entity.m35;
                vml.Entity.m40 = Entity.m40;
                vml.Entity.m50 = Entity.m50;
                vml.Entity.g10 = Entity.g10;
                vml.Entity.g20 = Entity.g20;
                vml.Entity.g25 = Entity.g25;
                vml.Entity.g30 = Entity.g30;
                vml.Entity.g35 = Entity.g35;
                vml.Entity.g40 = Entity.g40;
                vml.Entity.g45 = Entity.g45;
                vml.Entity.g50 = Entity.g50;
                vml.Entity.g60 = Entity.g60;
                vml.Entity.g70 = Entity.g70;
                vml.Entity.g80 = Entity.g80;
                vml.DoAdd();
            }
            else
            {
               
                vml.Entity.ID=oldStock.ID;
                vml.Entity.CompanyId = oldStock.CompanyId;
                vml.Entity.LocationId = oldStock.LocationId;
                vml.Entity.CreateBy = oldStock.CreateBy;
                vml.Entity.CreateTime = oldStock.CreateTime;
                vml.Entity.m10 = oldStock.m10 + Entity.m10;
                vml.Entity.m18 = oldStock.m18 + Entity.m18;
                vml.Entity.m20 = oldStock.m20 + Entity.m20;
                vml.Entity.m25 = oldStock.m25 + Entity.m25;
                vml.Entity.m28 = oldStock.m28 + Entity.m28;
                vml.Entity.m30 = oldStock.m30 + Entity.m30;
                vml.Entity.m35 = oldStock.m35 + Entity.m35;
                vml.Entity.m40 = oldStock.m40 + Entity.m40;
                vml.Entity.m50 = oldStock.m50 + Entity.m50;
                vml.Entity.g10 = oldStock.g10 + Entity.g10;
                vml.Entity.g20 = oldStock.g20 + Entity.g20;
                vml.Entity.g25 = oldStock.g25 + Entity.g25;
                vml.Entity.g30 = oldStock.g30 + Entity.g30;
                vml.Entity.g35 = oldStock.g35 + Entity.g35;
                vml.Entity.g40 = oldStock.g40 + Entity.g40;
                vml.Entity.g45 = oldStock.g45 + Entity.g45;
                vml.Entity.g50 = oldStock.g50 + Entity.g50;
                vml.Entity.g60 = oldStock.g60 + Entity.g60;
                vml.Entity.g70 = oldStock.g70 + Entity.g70;
                vml.Entity.g80 = oldStock.g80 + Entity.g80;
                vml.DoEdit(true);
            }



        }

    }
}
