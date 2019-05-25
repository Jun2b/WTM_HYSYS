using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInVMs
{
    public partial class StoreInTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Company_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.CompanyId);
        [Display(Name = "入库单号")]
        public ExcelPropety OrderSn_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.OrderSn);
        [Display(Name = "入库日期")]
        public ExcelPropety DateIn_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.DateIn);
        [Display(Name = "库位名称")]
        public ExcelPropety Location_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.LocationId);
        [Display(Name = "供应商名称")]
        public ExcelPropety Supplier_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.SupplierId);
        [Display(Name = "中母")]
        public ExcelPropety m10_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m10);
        [Display(Name = "1.8母")]
        public ExcelPropety m18_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m18);
        [Display(Name = "2母")]
        public ExcelPropety m20_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m20);
        [Display(Name = "2.5母")]
        public ExcelPropety m25_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m25);
        [Display(Name = "3母")]
        public ExcelPropety m30_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m30);
        [Display(Name = "3.5母")]
        public ExcelPropety m35_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m35);
        [Display(Name = "4母")]
        public ExcelPropety m40_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m40);
        [Display(Name = "5母")]
        public ExcelPropety m50_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.m50);
        [Display(Name = "中公")]
        public ExcelPropety g10_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g10);
        [Display(Name = "2公")]
        public ExcelPropety g20_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g20);
        [Display(Name = "2.5公")]
        public ExcelPropety g25_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g25);
        [Display(Name = "3公")]
        public ExcelPropety g30_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g30);
        [Display(Name = "3.5公")]
        public ExcelPropety g35_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g35);
        [Display(Name = "4公")]
        public ExcelPropety g40_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g40);
        [Display(Name = "4.5公")]
        public ExcelPropety g45_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g45);
        [Display(Name = "5公")]
        public ExcelPropety g50_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g50);
        [Display(Name = "6公")]
        public ExcelPropety g60_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g60);
        [Display(Name = "7公")]
        public ExcelPropety g70_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g70);
        [Display(Name = "8公")]
        public ExcelPropety g80_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.g80);
        [Display(Name = "总金额")]
        public ExcelPropety TotalPrice_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.TotalPrice);
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.Remark);
        [Display(Name = "确认状态")]
        public ExcelPropety isComfire_Excel = ExcelPropety.CreateProperty<StoreIn>(x => x.isComfire);

	    protected override void InitVM()
        {
            Company_Excel.DataType = ColumnDataType.ComboBox;
            Company_Excel.ListItems = DC.Set<Company>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
            Location_Excel.DataType = ColumnDataType.ComboBox;
            Location_Excel.ListItems = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
            Supplier_Excel.DataType = ColumnDataType.ComboBox;
            Supplier_Excel.ListItems = DC.Set<Supplier>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.SupplierName);
        }

    }

    public class StoreInImportVM : BaseImportVM<StoreInTemplateVM, StoreIn>
    {

    }

}
