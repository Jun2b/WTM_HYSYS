using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInVMs
{
    public partial class StoreInListVM : BasePagedListVM<StoreIn_View, StoreInSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("StoreIn", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<StoreIn_View>> InitGridHeader()
        {
            return new List<GridColumn<StoreIn_View>>{
                this.MakeGridHeader(x => x.OrderSn,width: 100),
                this.MakeGridHeader(x => x.DateIn,width: 100),
                this.MakeGridHeader(x => x.LocationName_view,width: 100),
                this.MakeGridHeader(x => x.SupplierName_view,width: 100),
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
                this.MakeGridHeader(x => x.TotalPrice),
                this.MakeGridHeader(x => x.Remark),
                this.MakeGridHeader(x => x.isComfire),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<StoreIn_View> GetSearchQuery()
        {
            var query = DC.Set<StoreIn>()
                .Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckContain(Searcher.OrderSn, x=>x.OrderSn)
                .CheckEqual(Searcher.DateIn, x=>x.DateIn)
                .CheckEqual(Searcher.LocationId, x=>x.LocationId)
                .CheckEqual(Searcher.SupplierId, x=>x.SupplierId)
                .CheckEqual(Searcher.isComfire, x=>x.isComfire)
                .Select(x => new StoreIn_View
                {
				    ID = x.ID,
                    OrderSn = x.OrderSn,
                    DateIn = x.DateIn,
                    LocationName_view = x.Location.LocationName,
                    SupplierName_view = x.Supplier.SupplierName,
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
                    TotalPrice = x.TotalPrice,
                    Remark = x.Remark,
                    isComfire = x.isComfire,
                    CreateTime = x.CreateTime
                })
                .OrderByDescending(x => x.CreateTime);
            return query;
        }

    }

    public class StoreIn_View : StoreIn{
        [Display(Name = "公司名称")]
        public String CompanyName_view { get; set; }
        [Display(Name = "仓库名称")]
        public String LocationName_view { get; set; }
        [Display(Name = "供应商名称")]
        public String SupplierName_view { get; set; }

    }
}
