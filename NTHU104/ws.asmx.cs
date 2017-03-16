using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using webtesting.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace webtesting
{
    /// <summary>
    ///ws 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    [System.Web.Script.Services.ScriptService]
    public class ws : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void getTestJobData()
        {
            List<jobtable> result = new List<jobtable>();
            result.Add(new jobtable("證券", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("金融", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "高雄", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "業務", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "業務", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("金融", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "高雄", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "台中", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("金融", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "高雄", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("金融", "業務", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "高雄", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("證券", "櫃台行員", "台中", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("金融", "業務", "台北", 3, "2017/03/10", "2017/05/10"));
            result.Add(new jobtable("工程", "工程師", "台中", 3, "2017/03/10", "2017/05/10"));

            //string resp = new JavaScriptSerializer().Serialize(result);

            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(JsonConvert.SerializeObject(result));
        }
    }
}
