using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.MyUserVMs
{
    public partial class MyUserSearcher : BaseSearcher
    {
        public List<ComboSelectListItem> AllCompanys { get; set; }
        [Display(Name = "所属公司")]
        public Guid? CompanyId { get; set; }
        [Display(Name = "账号")]
        public String ITCode { get; set; }
        [Display(Name = "姓名")]
        public String Name { get; set; }

        protected override void InitVM()
        {
            AllCompanys = DC.Set<Company>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

    }
}
