using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;
using HYSYS.ViewModels.WasteVMs;
using Microsoft.EntityFrameworkCore;


namespace HYSYS.ViewModels.ReStockVMs
{
    public partial class ReStockVM : BaseCRUDVM<ReStock>
    {
        public List<ComboSelectListItem> AllLocations { get; set; }

        public ReStockVM()
        {
            SetInclude(x => x.Location);
        }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
            //DC.Set<Stock>().Where(x=>x.LocationId==Entity.LocationId)

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
        public void DoComfire()
        {
            //APIHelper.CallAPI()
            ////DC.RunSP("UpdateStock", Entity.ID);

            Entity.isComfire = true;
            DoEdit();
            var oldWaste = DC.Set<Waste>().AsNoTracking().Where(x =>
                x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()) &&
                x.LocationId == Entity.LocationId).SingleOrDefault();
            var vml = new WasteVM();
            vml.CopyContext(this);
            if (oldWaste == null)
            {

                vml.Entity.CompanyId = Entity.CompanyId;
                vml.Entity.LocationId = Entity.LocationId;
                vml.Entity.m10 = Entity.m10-Entity.m10r;
                vml.Entity.m18 = Entity.m18- Entity.m18r;
                vml.Entity.m20 = Entity.m20- Entity.m20r;
                vml.Entity.m25 = Entity.m25- Entity.m25r;
                vml.Entity.m28 = Entity.m28- Entity.m28r;
                vml.Entity.m30 = Entity.m30- Entity.m30r;
                vml.Entity.m35 = Entity.m35- Entity.m35r;
                vml.Entity.m40 = Entity.m40- Entity.m40r;
                vml.Entity.m50 = Entity.m50- Entity.m50r;
                vml.Entity.g10 = Entity.g10- Entity.g10r;
                vml.Entity.g20 = Entity.g20- Entity.g20r;
                vml.Entity.g25 = Entity.g25- Entity.g25r;
                vml.Entity.g30 = Entity.g30- Entity.g30r;
                vml.Entity.g35 = Entity.g35- Entity.g35r;
                vml.Entity.g40 = Entity.g40- Entity.g40r;
                vml.Entity.g45 = Entity.g45- Entity.g45r;
                vml.Entity.g50 = Entity.g50- Entity.g50r;
                vml.Entity.g60 = Entity.g60- Entity.g60r;
                vml.Entity.g70 = Entity.g70- Entity.g70r;
                vml.Entity.g80 = Entity.g80- Entity.g80r;
                vml.DoAdd();
            }
            else
            {

                vml.Entity.ID = oldWaste.ID;
                vml.Entity.CompanyId = oldWaste.CompanyId;
                vml.Entity.LocationId = oldWaste.LocationId;
                vml.Entity.CreateBy = oldWaste.CreateBy;
                vml.Entity.CreateTime = oldWaste.CreateTime;
                vml.Entity.m10 = oldWaste.m10 + Entity.m10 - Entity.m10r;
                vml.Entity.m18 = oldWaste.m18 + Entity.m18 - Entity.m18r;
                vml.Entity.m20 = oldWaste.m20 + Entity.m20 - Entity.m20r;
                vml.Entity.m25 = oldWaste.m25 + Entity.m25- Entity.m25r;
                vml.Entity.m28 = oldWaste.m28 + Entity.m28- Entity.m28r;
                vml.Entity.m30 = oldWaste.m30 + Entity.m30- Entity.m30r;
                vml.Entity.m35 = oldWaste.m35 + Entity.m35- Entity.m35r;
                vml.Entity.m40 = oldWaste.m40 + Entity.m40- Entity.m40r;
                vml.Entity.m50 = oldWaste.m50 + Entity.m50- Entity.m50r;
                vml.Entity.g10 = oldWaste.g10 + Entity.g10- Entity.g10r;
                vml.Entity.g20 = oldWaste.g20 + Entity.g20- Entity.g20r;
                vml.Entity.g25 = oldWaste.g25 + Entity.g25- Entity.g25r;
                vml.Entity.g30 = oldWaste.g30 + Entity.g30- Entity.g30r;
                vml.Entity.g35 = oldWaste.g35 + Entity.g35- Entity.g35r;
                vml.Entity.g40 = oldWaste.g40 + Entity.g40- Entity.g40r;
                vml.Entity.g45 = oldWaste.g45 + Entity.g45- Entity.g45r;
                vml.Entity.g50 = oldWaste.g50 + Entity.g50- Entity.g50r;
                vml.Entity.g60 = oldWaste.g60 + Entity.g60- Entity.g60r;
                vml.Entity.g70 = oldWaste.g70 + Entity.g70- Entity.g70r;
                vml.Entity.g80 = oldWaste.g80 + Entity.g80- Entity.g80r;
                vml.DoEdit(true);
            }



        }
    }
}
