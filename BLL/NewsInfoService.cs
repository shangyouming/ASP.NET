using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class NewsInfoService
    {

        private NewsInfoDAL newsInfoDAL = new NewsInfoDAL();
        public List<NewsInfo> GetAllNews()
        {
            return newsInfoDAL.GetAllNews();
        }
    }
}
