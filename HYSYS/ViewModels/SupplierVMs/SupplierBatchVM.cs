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
    public partial class SupplierBatchVM : BaseBatchVM<Supplier, Supplier_BatchEdit>
    {
        public SupplierBatchVM()
        {
            ListVM = new SupplierListVM();
            LinkedVM = new Supplier_BatchEdit();
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
    public class Supplier_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
