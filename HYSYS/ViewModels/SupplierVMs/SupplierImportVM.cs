using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.SupplierVMs
{
    public partial class SupplierTemplateVM : BaseTemplateVM
    {
        [Display(Name = "本公司名称")]
        public ExcelPropety Company_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.CompanyId);
        [Display(Name = "供应商编码")]
        public ExcelPropety SupplierCode_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierCode);
        [Display(Name = "供应商名称")]
        public ExcelPropety SupplierName_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.SupplierName);
        [Display(Name = "联系方式")]
        public ExcelPropety PhoneNumber_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.PhoneNumber);
        
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<Supplier>(x => x.Remark);

	    protected override void InitVM()
        {
            Company_Excel.DataType = ColumnDataType.ComboBox;
            Company_Excel.ListItems = DC.Set<Company>()
                .Where(x => x.ID == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString()))
                .GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

    }

    public class SupplierImportVM : BaseImportVM<SupplierTemplateVM, Supplier>
    {

    }

}
