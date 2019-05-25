using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.SupplierVMs
{
    public partial class SupplierListVM : BasePagedListVM<Supplier_View, SupplierSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Supplier", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<Supplier_View>> InitGridHeader()
        {
            return new List<GridColumn<Supplier_View>>{
                this.MakeGridHeader(x => x.SupplierCode),
                this.MakeGridHeader(x => x.SupplierName),
                this.MakeGridHeader(x => x.PhoneNumber),
                this.MakeGridHeader(x => x.Remark),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Supplier_View> GetSearchQuery()
        {
            var query = DC.Set<Supplier>()
                .Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckContain(Searcher.SupplierCode, x=>x.SupplierCode)
                .CheckContain(Searcher.SupplierName, x=>x.SupplierName)
                .CheckContain(Searcher.PhoneNumber, x=>x.PhoneNumber)
                .Select(x => new Supplier_View
                {
				    ID = x.ID,
                    SupplierCode = x.SupplierCode,
                    SupplierName = x.SupplierName,
                    PhoneNumber = x.PhoneNumber,
                    Remark = x.Remark,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Supplier_View : Supplier{

    }
}
