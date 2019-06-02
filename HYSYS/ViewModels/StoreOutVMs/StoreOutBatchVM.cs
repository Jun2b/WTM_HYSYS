using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StoreOutVMs
{
    public partial class StoreOutBatchVM : BaseBatchVM<StoreOut, StoreOut_BatchEdit>
    {
        public StoreOutBatchVM()
        {
            ListVM = new StoreOutListVM();
            LinkedVM = new StoreOut_BatchEdit();
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
    public class StoreOut_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
