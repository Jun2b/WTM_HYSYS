using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.LocationVMs
{
    public partial class LocationListVM : BasePagedListVM<Location_View, LocationSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Location", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<Location_View>> InitGridHeader()
        {
            return new List<GridColumn<Location_View>>{
                this.MakeGridHeader(x => x.LocationCode),
                this.MakeGridHeader(x => x.LocationName),
                this.MakeGridHeader(x => x.Remark),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Location_View> GetSearchQuery()
        {
            var query = DC.Set<Location>()
                .Where(x=>x.CompanyId==new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckContain(Searcher.LocationCode, x=>x.LocationCode)
                .CheckContain(Searcher.LocationName, x=>x.LocationName)
                .Select(x => new Location_View
                {
				    ID = x.ID,
                    LocationCode = x.LocationCode,
                    LocationName = x.LocationName,
                    Remark = x.Remark,
                    
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Location_View : Location{

    }
}
