using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInPriceVMs
{
    public partial class StoreInPriceListVM : BasePagedListVM<StoreInPrice_View, StoreInPriceSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("StoreInPrice", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<StoreInPrice_View>> InitGridHeader()
        {
            return new List<GridColumn<StoreInPrice_View>>{
                this.MakeGridHeader(x => x.DateIn),
                this.MakeGridHeader(x => x.m10p),
                this.MakeGridHeader(x => x.m18p),
                this.MakeGridHeader(x => x.m20p),
                this.MakeGridHeader(x => x.m25p),
                this.MakeGridHeader(x => x.m28p),
                this.MakeGridHeader(x => x.m30p),
                this.MakeGridHeader(x => x.m35p),
                this.MakeGridHeader(x => x.m40p),
                this.MakeGridHeader(x => x.m50p),
                this.MakeGridHeader(x => x.g10p),
                this.MakeGridHeader(x => x.g20p),
                this.MakeGridHeader(x => x.g25p),
                this.MakeGridHeader(x => x.g30p),
                this.MakeGridHeader(x => x.g35p),
                this.MakeGridHeader(x => x.g40p),
                this.MakeGridHeader(x => x.g45p),
                this.MakeGridHeader(x => x.g50p),
                this.MakeGridHeader(x => x.g60p),
                this.MakeGridHeader(x => x.g70p),
                this.MakeGridHeader(x => x.g80p),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<StoreInPrice_View> GetSearchQuery()
        {
            var query = DC.Set<StoreInPrice>()
                .Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckEqual(Searcher.DateIn, x=>x.DateIn)
                .Select(x => new StoreInPrice_View
                {
				    ID = x.ID,
                    DateIn = x.DateIn,
                    m10p = x.m10p,
                    m18p = x.m18p,
                    m20p = x.m20p,
                    m25p = x.m25p,
                    m28p = x.m28p,
                    m30p = x.m30p,
                    m35p = x.m35p,
                    m40p = x.m40p,
                    m50p = x.m50p,
                    g10p = x.g10p,
                    g20p = x.g20p,
                    g25p = x.g25p,
                    g30p = x.g30p,
                    g35p = x.g35p,
                    g40p = x.g40p,
                    g45p = x.g45p,
                    g50p = x.g50p,
                    g60p = x.g60p,
                    g70p = x.g70p,
                    g80p = x.g80p,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class StoreInPrice_View : StoreInPrice{

    }
}
