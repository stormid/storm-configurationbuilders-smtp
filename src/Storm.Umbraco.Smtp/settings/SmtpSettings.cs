using System;
using System.Collections.Specialized;
using System.Configuration;
using Storm.Umbraco.Smtp.helpers;

namespace Storm.Umbraco.Smtp.Settings
{
    public class SmtpSettings : ISmtpSettings
    {
        private const string Prefix = "Smtp:";
        private readonly NameValueCollection nvc;

        public SmtpSettings() : this(ConfigurationManager.AppSettings)
        {
        }

        public SmtpSettings(NameValueCollection nvc)
        {
            this.nvc = nvc ?? throw new ArgumentNullException(nameof(nvc), "You must supply a NameValueCollection");
        }

        public string From => ParseHelper.ParseString(nvc[$"{Prefix}{nameof(From)}"]);

        public string Host => ParseHelper.ParseString(nvc[$"{Prefix}{nameof(Host)}"]);

        public int Port => ParseHelper.ParseInt(nvc[$"{Prefix}{nameof(Port)}"], 25);

        public string Username => ParseHelper.ParseString(nvc[$"{Prefix}{nameof(Username)}"]);

        public string Password => ParseHelper.ParseString(nvc[$"{Prefix}{nameof(Password)}"]);

        public bool EnableSsl => ParseHelper.ParseBoolean(nvc[$"{Prefix}{nameof(EnableSsl)}"], false);
    }
}