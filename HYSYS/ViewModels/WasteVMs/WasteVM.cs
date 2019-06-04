using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using HYSYS.Models;


namespace HYSYS.ViewModels.WasteVMs
{
    public partial class WasteVM : BaseCRUDVM<Waste>
    {
        public List<ComboSelectListItem> AllLocations { get; set; }

        public WasteVM()
        {
            SetInclude(x => x.Location);
        }

        protected override void InitVM()
        {
            AllLocations = DC.Set<Location>().GetSelectListItems(LoginUserInfo.DataPrivileges, null, y => y.LocationName);
        }

        public override void DoAdd()
        {           
            base.DoAdd();
        }

        public override void DoEdit(bool updateAllFields = false)
        {
            base.DoEdit(updateAllFields);
        }

        public override void DoDelete()
        {
            base.DoDelete();
        }
    }
}
