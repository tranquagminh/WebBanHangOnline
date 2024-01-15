using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Common
{
    public class SettingHelper
    {
        private static ApplicationDbContext db = new ApplicationDbContext();
        public static string GetValue(string key)
        {
            var item = db.SystemSetting.SingleOrDefault(x => x.SettingKey.Equals(key));
            if(item != null)
            {
                return item.SettingValue;
            }
            return "";
        }
    }
}