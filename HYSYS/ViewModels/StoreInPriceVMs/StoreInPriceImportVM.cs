using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreInPriceVMs
{
    public partial class StoreInPriceTemplateVM : BaseTemplateVM
    {
        [Display(Name = "入库日期")]
        public ExcelPropety DateIn_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.DateIn);
        [Display(Name = "中母")]
        public ExcelPropety m10p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m10p);
        [Display(Name = "1.8母")]
        public ExcelPropety m18p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m18p);
        [Display(Name = "2母")]
        public ExcelPropety m20p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m20p);
        [Display(Name = "2.5母")]
        public ExcelPropety m25p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m25p);
        [Display(Name = "2.8母")]
        public ExcelPropety m28p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m28p);
        [Display(Name = "3母")]
        public ExcelPropety m30p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m30p);
        [Display(Name = "3.5母")]
        public ExcelPropety m35p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m35p);
        [Display(Name = "4母")]
        public ExcelPropety m40p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m40p);
        [Display(Name = "5母")]
        public ExcelPropety m50p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.m50p);
        [Display(Name = "中公")]
        public ExcelPropety g10p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g10p);
        [Display(Name = "2公")]
        public ExcelPropety g20p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g20p);
        [Display(Name = "2.5公")]
        public ExcelPropety g25p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g25p);
        [Display(Name = "3公")]
        public ExcelPropety g30p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g30p);
        [Display(Name = "3.5公")]
        public ExcelPropety g35p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g35p);
        [Display(Name = "4公")]
        public ExcelPropety g40p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g40p);
        [Display(Name = "4.5公")]
        public ExcelPropety g45p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g45p);
        [Display(Name = "5公")]
        public ExcelPropety g50p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g50p);
        [Display(Name = "6公")]
        public ExcelPropety g60p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g60p);
        [Display(Name = "7公")]
        public ExcelPropety g70p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g70p);
        [Display(Name = "8公")]
        public ExcelPropety g80p_Excel = ExcelPropety.CreateProperty<StoreInPrice>(x => x.g80p);

	    protected override void InitVM()
        {
        }

    }

    public class StoreInPriceImportVM : BaseImportVM<StoreInPriceTemplateVM, StoreInPrice>
    {

    }

}
