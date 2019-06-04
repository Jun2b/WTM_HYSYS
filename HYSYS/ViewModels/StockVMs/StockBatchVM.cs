using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.StockVMs
{
    public partial class StockBatchVM : BaseBatchVM<Stock, Stock_BatchEdit>
    {
        public StockBatchVM()
        {
            ListVM = new StockListVM();
            LinkedVM = new Stock_BatchEdit();
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
    public class Stock_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
