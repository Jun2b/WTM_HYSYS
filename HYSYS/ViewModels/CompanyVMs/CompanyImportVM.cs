using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.CompanyVMs
{
    public partial class CompanyTemplateVM : BaseTemplateVM
    {
        [Display(Name = "公司编码")]
        public ExcelPropety CompanyCode_Excel = ExcelPropety.CreateProperty<Company>(x => x.CompanyCode);
        [Display(Name = "公司名称")]
        public ExcelPropety CompanyName_Excel = ExcelPropety.CreateProperty<Company>(x => x.CompanyName);
        [Display(Name = "备注")]
        public ExcelPropety Remark_Excel = ExcelPropety.CreateProperty<Company>(x => x.Remark);

	    protected override void InitVM()
        {
        }

    }

    public class CompanyImportVM : BaseImportVM<CompanyTemplateVM, Company>
    {

    }

}
