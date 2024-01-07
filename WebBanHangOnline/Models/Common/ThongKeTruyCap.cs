﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.Common
{
    public class ThongKeTruyCap
    {
        private static string strConnect = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        public static ThongKeViewModel ThongKe()
        {
            using(var connect = new SqlConnection(strConnect))
            {
                var item = connect.QueryFirstOrDefault<ThongKeViewModel>("ssp_ThongKe", commandType: CommandType.StoredProcedure);
                return item;
            }
        }
    }
}