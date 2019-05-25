using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.CustomerVMs
{
    public partial class CustomerListVM : BasePagedListVM<Customer_View, CustomerSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.Details, "详细","", dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("Customer", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<Customer_View>> InitGridHeader()
        {
            return new List<GridColumn<Customer_View>>{
                this.MakeGridHeader(x => x.CustomerCode),
                this.MakeGridHeader(x => x.CustomerName),
                this.MakeGridHeader(x => x.PhoneNumber),
                this.MakeGridHeader(x => x.Remark),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Customer_View> GetSearchQuery()
        {
            var query = DC.Set<Customer>()
                .Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckContain(Searcher.CustomerCode, x=>x.CustomerCode)
                .CheckContain(Searcher.CustomerName, x=>x.CustomerName)
                .CheckContain(Searcher.PhoneNumber, x=>x.PhoneNumber)
                .Select(x => new Customer_View
                {
				    ID = x.ID,
                    CustomerCode = x.CustomerCode,
                    CustomerName = x.CustomerName,
                    PhoneNumber = x.PhoneNumber,
                    Remark = x.Remark,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Customer_View : Customer{

    }
}
