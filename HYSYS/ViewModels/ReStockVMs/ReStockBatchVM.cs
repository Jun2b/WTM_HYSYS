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
    public partial class ReStockBatchVM : BaseBatchVM<ReStock, ReStock_BatchEdit>
    {
        public ReStockBatchVM()
        {
            ListVM = new ReStockListVM();
            LinkedVM = new ReStock_BatchEdit();
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
    public class ReStock_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
