using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HYSYS.Models;
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

    }
}