using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SimpleDemo.WebApi
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "初始化")]
        public string init(string jkxlh)
        {
            return jkxlh;
        }

        [WebMethod(Description = "初始化")]
        public string init1(string jczbh, string jcxdh, string zdlx, string ip, string mac)
        {
            return jczbh;
        }

        [WebMethod(Description = "申请授权")]
        public string sqsq(string zdlx)
        {
            return zdlx;
        }


    }
}
