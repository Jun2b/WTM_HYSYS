﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreOutVMs
{
    public partial class StoreOutListVM : BasePagedListVM<StoreOut_View, StoreOutSearcher>
    {
        protected override List<GridAction> InitGridAction()
        {
            return new List<GridAction>
            {
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.Create, "新建","", dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.Edit, "修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.Delete, "删除", "",dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.Details, "详细/确认","", dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.BatchEdit, "批量修改","", dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.BatchDelete, "批量删除","", dialogWidth: 800),
                this.MakeStandardAction("StoreOut", GridActionStandardTypesEnum.Import, "导入","", dialogWidth: 800),
                this.MakeStandardExportAction(null,false,ExportEnum.Excel)
            };
        }

        protected override IEnumerable<IGridColumn<StoreOut_View>> InitGridHeader()
        {
            return new List<GridColumn<StoreOut_View>>{
                this.MakeGridHeader(x => x.isComfire),
                this.MakeGridHeader(x => x.OrderSn),
                this.MakeGridHeader(x => x.DateOut),
                this.MakeGridHeader(x => x.LocationName_view),
                this.MakeGridHeader(x => x.CustomerName_view),
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
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<StoreOut_View> GetSearchQuery()
        {
            var query = DC.Set<StoreOut>()
                .Where(x => x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .CheckContain(Searcher.OrderSn, x=>x.OrderSn)
                .CheckEqual(Searcher.DateOut, x=>x.DateOut)
                .CheckEqual(Searcher.LocationId, x=>x.LocationId)
                .CheckEqual(Searcher.CustomerId, x=>x.CustomerId)
                .CheckEqual(Searcher.isComfire, x=>x.isComfire)
                .Select(x => new StoreOut_View
                {
				    ID = x.ID,
                    OrderSn = x.OrderSn,
                    DateOut = x.DateOut,
                    LocationName_view = x.Location.LocationName,
                    CustomerName_view = x.Customer.CustomerName,
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
                })
                .OrderByDescending(x => x.CreateTime);
            return query;
        }

    }

    public class StoreOut_View : StoreOut{
        [Display(Name = "仓库名称")]
        public String LocationName_view { get; set; }
        [Display(Name = "客户名称")]
        public String CustomerName_view { get; set; }

    }
}
