using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.ReStockVMs
{
    public partial class ReStockListVM : BasePagedListVM<ReStock_View, ReStockSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("ReStock", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<ReStock_View>> InitGridHeader()
        {
            return new List<GridColumn<ReStock_View>>{
                this.MakeGridHeader(x => x.isComfire),
                this.MakeGridHeader(x => x.LocationName_view),
                this.MakeGridHeader(x => x.m10),
                this.MakeGridHeader(x => x.m18),
                this.MakeGridHeader(x => x.m20),
                this.MakeGridHeader(x => x.m25),
                this.MakeGridHeader(x => x.m28),
                this.MakeGridHeader(x => x.m30),
                this.MakeGridHeader(x => x.m35),
                this.MakeGridHeader(x => x.m40),
                this.MakeGridHeader(x => x.m50),
                this.MakeGridHeader(x => x.g10),
                this.MakeGridHeader(x => x.g20),
                this.MakeGridHeader(x => x.g25),
                this.MakeGridHeader(x => x.g30),
                this.MakeGridHeader(x => x.g35),
                this.MakeGridHeader(x => x.g40),
                this.MakeGridHeader(x => x.g45),
                this.MakeGridHeader(x => x.g50),
                this.MakeGridHeader(x => x.g60),
                this.MakeGridHeader(x => x.g70),
                this.MakeGridHeader(x => x.g80),
                this.MakeGridHeader(x => x.m10r),
                this.MakeGridHeader(x => x.m18r),
                this.MakeGridHeader(x => x.m20r),
                this.MakeGridHeader(x => x.m25r),
                this.MakeGridHeader(x => x.m28r),
                this.MakeGridHeader(x => x.m30r),
                this.MakeGridHeader(x => x.m35r),
                this.MakeGridHeader(x => x.m40r),
                this.MakeGridHeader(x => x.m50r),
                this.MakeGridHeader(x => x.g10r),
                this.MakeGridHeader(x => x.g20r),
                this.MakeGridHeader(x => x.g25r),
                this.MakeGridHeader(x => x.g30r),
                this.MakeGridHeader(x => x.g35r),
                this.MakeGridHeader(x => x.g40r),
                this.MakeGridHeader(x => x.g45r),
                this.MakeGridHeader(x => x.g50r),
                this.MakeGridHeader(x => x.g60r),
                this.MakeGridHeader(x => x.g70r),
                this.MakeGridHeader(x => x.g80r),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<ReStock_View> GetSearchQuery()
        {
            var query = DC.Set<ReStock>()
                .Where(x=>x.CompanyId==new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckEqual(Searcher.LocationId, x=>x.LocationId)
                .CheckEqual(Searcher.isComfire, x => x.isComfire)
                .Select(x => new ReStock_View
                {
				    ID = x.ID,
                    LocationName_view = x.Location.LocationName,
                    m10 = x.m10,
                    m18 = x.m18,
                    m20 = x.m20,
                    m25 = x.m25,
                    m28 = x.m28,
                    m30 = x.m30,
                    m35 = x.m35,
                    m40 = x.m40,
                    m50 = x.m50,
                    g10 = x.g10,
                    g20 = x.g20,
                    g25 = x.g25,
                    g30 = x.g30,
                    g35 = x.g35,
                    g40 = x.g40,
                    g45 = x.g45,
                    g50 = x.g50,
                    g60 = x.g60,
                    g70 = x.g70,
                    g80 = x.g80,
                    m10r = x.m10r,
                    m18r = x.m18r,
                    m20r = x.m20r,
                    m25r = x.m25r,
                    m28r = x.m28r,
                    m30r = x.m30r,
                    m35r = x.m35r,
                    m40r = x.m40r,
                    m50r = x.m50r,
                    g10r = x.g10r,
                    g20r = x.g20r,
                    g25r = x.g25r,
                    g30r = x.g30r,
                    g35r = x.g35r,
                    g40r = x.g40r,
                    g45r = x.g45r,
                    g50r = x.g50r,
                    g60r = x.g60r,
                    g70r = x.g70r,
                    g80r = x.g80r,
                    isComfire = x.isComfire
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class ReStock_View : ReStock{
        [Display(Name = "仓库名称")]
        public String LocationName_view { get; set; }

    }
}
