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
    public partial class StoreInPriceBatchVM : BaseBatchVM<StoreInPrice, StoreInPrice_BatchEdit>
    {
        public StoreInPriceBatchVM()
        {
            ListVM = new StoreInPriceListVM();
            LinkedVM = new StoreInPrice_BatchEdit();
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
    public class StoreInPrice_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
