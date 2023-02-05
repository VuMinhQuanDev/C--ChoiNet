using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanNet
{
    internal class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string usingCom { get; set; }
        public float money { get; set; }
        public TimeSpan time { get; set; }
        public string status { get; set; }
        public TimeSpan getTime(float money)
        {
            TimeSpan Time = TimeSpan.FromMinutes((money/1000) * 12);
            return Time;
        }
    }
}
