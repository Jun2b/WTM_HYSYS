using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HYSYS.Models;
using HYSYS.ViewModels.StockVMs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.XSSF.Streaming.Values;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;

namespace HYSYS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllRights]
    public class DataApiController : BaseApiController
    {
        public class PriceReturn
        {
            public string ResultCode { get; set; }
            public StoreInPrice sip { get; set; }
        }
        #region 获取时间价格
        [HttpPost]
        public ActionResult PriceGet()
        {
            DateTime dateTime=DateTime.Parse(Request.Form["dTime"]);
            var prices = DC.Set<StoreInPrice>().Where(x => x.DateIn == dateTime && x.CompanyId == new Guid(LoginUserInfo.Attributes["CompanyId"].ToString())).OrderByDescending(x => x.CreateTime).FirstOrDefault();
            PriceReturn pr=new PriceReturn();
            if (prices == null)
            {
                pr.ResultCode = "1";
            }
            else
            {
                pr.ResultCode = "0";
                pr.sip = prices;
            }
            return new JsonResult(pr);
        }
        #endregion

        //#region 确认入库更新库存

        //[HttpPost]
        //[AllRights]
        //public ActionResult StoreInComfire(Guid id)
        //{
        //    var thisStoreIn = DC.Set<StoreIn>().Where(x => x.ID == id).SingleOrDefault();
        //    if (thisStoreIn==null)
        //    {
        //        return new JsonResult("Failed");
        //    }
        //    var oldStock = DC.Set<Stock>().Where(x =>
        //        x.LocationId == thisStoreIn.LocationId).SingleOrDefault();
        //    if (oldStock==null)
        //    {
        //        var vml = CreateVM<StockVM>();
        //        vml.Entity.CompanyId = thisStoreIn.CompanyId;
        //        vml.Entity.LocationId = thisStoreIn.LocationId;
        //        vml.Entity.m10 = thisStoreIn.m10;
        //        vml.Entity.m18 = thisStoreIn.m18;
        //        vml.Entity.m20 = thisStoreIn.m20;
        //        vml.Entity.m25 = thisStoreIn.m25;
        //        vml.Entity.m28 = thisStoreIn.m28;
        //        vml.Entity.m30 = thisStoreIn.m30;
        //        vml.Entity.m35 = thisStoreIn.m35;
        //        vml.Entity.m40 = thisStoreIn.m40;
        //        vml.Entity.m50 = thisStoreIn.m50;
        //        vml.Entity.g10 = thisStoreIn.g10;
        //        vml.Entity.g20 = thisStoreIn.g20;
        //        vml.Entity.g25 = thisStoreIn.g25;
        //        vml.Entity.g30 = thisStoreIn.g30;
        //        vml.Entity.g35 = thisStoreIn.g35;
        //        vml.Entity.g40 = thisStoreIn.g40;
        //        vml.Entity.g45 = thisStoreIn.g45;
        //        vml.Entity.g50 = thisStoreIn.g50;
        //        vml.Entity.g60 = thisStoreIn.g60;
        //        vml.Entity.g70 = thisStoreIn.g70;
        //        vml.Entity.g80 = thisStoreIn.g80;
        //        vml.DoAdd();
        //        return new JsonResult("Succeed");
        //    }
        //    else
        //    {
        //        var vml = CreateVM<StockVM>(thisStoreIn.ID);
        //        vml.Entity.m10 = oldStock.m10 + thisStoreIn.m10;
        //        vml.Entity.m18 = oldStock.m18 + thisStoreIn.m18;
        //        vml.Entity.m20 = oldStock.m20 + thisStoreIn.m20;
        //        vml.Entity.m25 = oldStock.m25 + thisStoreIn.m25;
        //        vml.Entity.m28 = oldStock.m28 + thisStoreIn.m28;
        //        vml.Entity.m30 = oldStock.m30 + thisStoreIn.m30;
        //        vml.Entity.m35 = oldStock.m35 + thisStoreIn.m35;
        //        vml.Entity.m40 = oldStock.m40 + thisStoreIn.m40;
        //        vml.Entity.m50 = oldStock.m50 + thisStoreIn.m50;
        //        vml.Entity.g10 = oldStock.g10 + thisStoreIn.g10;
        //        vml.Entity.g20 = oldStock.g20 + thisStoreIn.g20;
        //        vml.Entity.g25 = oldStock.g25 + thisStoreIn.g25;
        //        vml.Entity.g30 = oldStock.g30 + thisStoreIn.g30;
        //        vml.Entity.g35 = oldStock.g35 + thisStoreIn.g35;
        //        vml.Entity.g40 = oldStock.g40 + thisStoreIn.g40;
        //        vml.Entity.g45 = oldStock.g45 + thisStoreIn.g45;
        //        vml.Entity.g50 = oldStock.g50 + thisStoreIn.g50;
        //        vml.Entity.g60 = oldStock.g60 + thisStoreIn.g60;
        //        vml.Entity.g70 = oldStock.g70 + thisStoreIn.g70;
        //        vml.Entity.g80 = oldStock.g80 + thisStoreIn.g80;
        //        vml.DoEdit();
        //        return new JsonResult("Succeed");
        //    }
            
        //}
        

        //#endregion

    }
}