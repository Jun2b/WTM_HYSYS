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
    public partial class CustomerBatchVM : BaseBatchVM<Customer, Customer_BatchEdit>
    {
        public CustomerBatchVM()
        {
            ListVM = new CustomerListVM();
            LinkedVM = new Customer_BatchEdit();
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
    public class Customer_BatchEdit : BaseVM
    {

        protected override void InitVM()
        {
        }

    }

}
