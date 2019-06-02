using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.CustomerVMs
{
    public partial class CustomerTemplateVM : BaseTemplateVM
    {
        [Display(Name = "客户编码")]
        public ExcelPropety CustomerCode_Excel = ExcelPropety.CreateProperty<Customer>(x => x.CustomerCode);
        [Display(Name = "客户名称")]
        public ExcelPropety CustomerName_Excel = ExcelPropety.CreateProperty<Customer>(x => x.CustomerName);
        [Display(Name = "联系方式")]
        public ExcelPropety PhoneNumber_Excel = ExcelPropety.CreateProperty<Customer>(x => x.PhoneNumber);
        [Display(Name = "所属公司")]
        public ExcelPropety Company_Excel = ExcelPropety.CreateProperty<Customer>(x => x.CompanyId);
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<Customer>(x => x.Remark);

	    protected override void InitVM()
        {
            Company_Excel.DataType = ColumnDataType.ComboBox;
            Company_Excel.ListItems = DC.Set<Company>().Where(x=>x.ID==new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

    }

    public class CustomerImportVM : BaseImportVM<CustomerTemplateVM, Customer>
    {

    }

}
