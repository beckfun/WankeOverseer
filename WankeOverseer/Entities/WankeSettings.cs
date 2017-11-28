﻿using WankeOverseer.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WankeOverseer.Entities
{
    public class WankeSettings
    {
        public WankeSettings()
        {
            loginDatas = new List<LoginData>();
            mailAccount = new MailAccount
            {
                port = 25,
                smtpServer = "smtp.qq.com"
            };
        }
        public List<string> priceNotifyItem { get; set; }
        public bool autoRefresh { get; set; }
        public bool mailNotify { get; set; }
        public bool serverchanNotify { get; set; }
        public string SCKEY { get; set; }
        public string SortBy { get; set; }
        public int SortOrder { get; set; }
        public List<LoginData> loginDatas { get; set; }
        public MailAccount mailAccount { get; set; }
        public int refresh_allSpan { get; set; }
        public int autoTibi { get; set; }
        public double priceAbove { get; set; }
        public double priceBelow { get; set; }
    }
    public class MailAccount
    {
        public string username { get; set; }
        public string password { get; set; }
        public string smtpServer { get; set; }
        public int port { get; set; }
        public string mailTo { get; set; }
    }
}
