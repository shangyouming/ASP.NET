using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

namespace ThreeLayerWebDemo.News
{
    /// <summary>
    /// NewsList 的摘要说明
    /// </summary>
    public class NewsList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            //context.Response.Write("Hello World");
            BLL.NewsInfoService newsInfoService = new BLL.NewsInfoService();
            List<NewsInfo> newsList= newsInfoService.GetAllNews();
            StringBuilder sb = new StringBuilder();
            foreach (var item in newsList)
            {
                //<th>编号</th><th>标题</th><th>日期</th><th>创建人</th><th>操作</th> 
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>详情</td></tr>",
                    item.ID,
                    item.Title,
                    item.Date,
                    item.People
                    );
            }
         string str=   context.Request.MapPath("NewsListTemp.html");
            string tempString = File.ReadAllText(context.Request.MapPath("NewsListTemp.html"));
            string result = tempString.Replace("@trbody", sb.ToString());
            context.Response.Write(result);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}