using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.ReStockVMs
{
    public partial class ReStockTemplateVM : BaseTemplateVM
    {
        [Display(Name = "仓库库位")]
        public ExcelPropety Location_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.LocationId);
        [Display(Name = "中母")]
        public ExcelPropety m10_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m10);
        [Display(Name = "1.8母")]
        public ExcelPropety m18_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m18);
        [Display(Name = "2母")]
        public ExcelPropety m20_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m20);
        [Display(Name = "2.5母")]
        public ExcelPropety m25_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m25);
        [Display(Name = "2.8母")]
        public ExcelPropety m28_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m28);
        [Display(Name = "3母")]
        public ExcelPropety m30_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m30);
        [Display(Name = "3.5母")]
        public ExcelPropety m35_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m35);
        [Display(Name = "4母")]
        public ExcelPropety m40_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m40);
        [Display(Name = "5母")]
        public ExcelPropety m50_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m50);
        [Display(Name = "中公")]
        public ExcelPropety g10_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g10);
        [Display(Name = "2公")]
        public ExcelPropety g20_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g20);
        [Display(Name = "2.5公")]
        public ExcelPropety g25_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g25);
        [Display(Name = "3公")]
        public ExcelPropety g30_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g30);
        [Display(Name = "3.5公")]
        public ExcelPropety g35_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g35);
        [Display(Name = "4公")]
        public ExcelPropety g40_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g40);
        [Display(Name = "4.5公")]
        public ExcelPropety g45_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g45);
        [Display(Name = "5公")]
        public ExcelPropety g50_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g50);
        [Display(Name = "6公")]
        public ExcelPropety g60_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g60);
        [Display(Name = "7公")]
        public ExcelPropety g70_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g70);
        [Display(Name = "8公")]
        public ExcelPropety g80_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g80);
        [Display(Name = "中母")]
        public ExcelPropety m10r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m10r);
        [Display(Name = "1.8母")]
        public ExcelPropety m18r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m18r);
        [Display(Name = "2母")]
        public ExcelPropety m20r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m20r);
        [Display(Name = "2.5母")]
        public ExcelPropety m25r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m25r);
        [Display(Name = "2.8母")]
        public ExcelPropety m28r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m28r);
        [Display(Name = "3母")]
        public ExcelPropety m30r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m30r);
        [Display(Name = "3.5母")]
        public ExcelPropety m35r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m35r);
        [Display(Name = "4母")]
        public ExcelPropety m40r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m40r);
        [Display(Name = "5母")]
        public ExcelPropety m50r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.m50r);
        [Display(Name = "中公")]
        public ExcelPropety g10r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g10r);
        [Display(Name = "2公")]
        public ExcelPropety g20r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g20r);
        [Display(Name = "2.5公")]
        public ExcelPropety g25r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g25r);
        [Display(Name = "3公")]
        public ExcelPropety g30r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g30r);
        [Display(Name = "3.5公")]
        public ExcelPropety g35r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g35r);
        [Display(Name = "4公")]
        public ExcelPropety g40r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g40r);
        [Display(Name = "4.5公")]
        public ExcelPropety g45r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g45r);
        [Display(Name = "5公")]
        public ExcelPropety g50r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g50r);
        [Display(Name = "6公")]
        public ExcelPropety g60r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g60r);
        [Display(Name = "7公")]
        public ExcelPropety g70r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g70r);
        [Display(Name = "8公")]
        public ExcelPropety g80r_Excel = ExcelPropety.CreateProperty<ReStock>(x => x.g80r);

	    protected override void InitVM()
        {
            Location_Excel.DataType = ColumnDataType.ComboBox;
            Location_Excel.ListItems = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
        }

    }

    public class ReStockImportVM : BaseImportVM<ReStockTemplateVM, ReStock>
    {

    }

}
