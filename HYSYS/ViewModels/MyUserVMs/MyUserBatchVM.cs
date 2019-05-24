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
    public partial class MyUserBatchVM : BaseBatchVM<MyUser, MyUser_BatchEdit>
    {
        public MyUserBatchVM()
        {
            ListVM = new MyUserListVM();
            LinkedVM = new MyUser_BatchEdit();
        }

        protected override bool CheckIfCanDelete(Guid id, out string errorMessage)
        {
            errorMessage = null;
			return true;
        }
    }

	/// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class MyUser_BatchEdit : BaseVM
    {
        public List<ComboSelectListItem> AllCompanys { get; set; }
        [Display(Name = "所属公司")]
        public Guid? CompanyId { get; set; }

        protected override void InitVM()
        {
            AllCompanys = DC.Set<Company>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.CompanyName);
        }

    }

}
