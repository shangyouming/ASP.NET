using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsInfoDAL
    {
        public  List<NewsInfo> GetAllNews()
        {
          DataTable dt=   SqlHelper.ExecuteDataTable("SELECT ID,title,[Date],people FROM  dbo.HKSJ_Main", CommandType.Text);

            List<NewsInfo> list = new List<NewsInfo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NewsInfo news = new NewsInfo();
                news.ID = (Int32)dt.Rows[i]["ID"];
                news.Title = dt.Rows[i]["title"] as string;
                news.Date = DateTime.Parse(dt.Rows[i]["Date"].ToString());
                news.People = dt.Rows[i]["people"] as string;
                list.Add(news);
            }
            return list;
        }
    }
}
