using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.LocationVMs
{
    public partial class LocationTemplateVM : BaseTemplateVM
    {
        [Display(Name = "仓库编码")]
        public ExcelPropety LocationCode_Excel = ExcelPropety.CreateProperty<Location>(x => x.LocationCode);
        [Display(Name = "仓库名称")]
        public ExcelPropety LocationName_Excel = ExcelPropety.CreateProperty<Location>(x => x.LocationName);
        [Display(Name = "所属公司")]
        public ExcelPropety Company_Excel = ExcelPropety.CreateProperty<Location>(x => x.CompanyId);
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<Location>(x => x.Remark);

	    protected override void InitVM()
        {
            Company_Excel.DataType = ColumnDataType.ComboBox;
            Company_Excel.ListItems = DC.Set<Company>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

    }

    public class LocationImportVM : BaseImportVM<LocationTemplateVM, Location>
    {

    }

}
