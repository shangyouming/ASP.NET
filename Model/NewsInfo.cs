using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class NewsInfo
    {
        public int ID { get; set; }
        public string  Title { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string  People { get; set; }
        public string  PicUrl { get; set; }

    }
}
