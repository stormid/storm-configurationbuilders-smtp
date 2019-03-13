using System.Collections.Specialized;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using Storm.Umbraco.Smtp.Settings;

namespace Storm.Umbraco.Smtp.configbuilders
{
    public class SmtpConfigBuilder : ConfigurationBuilder
    {
        public SmtpConfigBuilder() : this(ConfigurationManager.AppSettings)
        {
        }

        public SmtpConfigBuilder(NameValueCollection nvc) : this(new SmtpSettings(nvc))
        {
        }

        public SmtpConfigBuilder(ISmtpSettings settings)
        {
        }

        public override ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection)
        {
            if (configSection is SmtpSection smtpSection)
            {
                var config = new SmtpSettings();
                smtpSection.From = config.From;
                smtpSection.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpSection.Network.Host = config.Host;
                smtpSection.Network.Port = config.Port;
                smtpSection.Network.UserName = config.Username;
                smtpSection.Network.Password = config.Password;
                smtpSection.Network.EnableSsl = config.EnableSsl;

                return smtpSection;
            }
            return base.ProcessConfigurationSection(configSection);
        }
    }
}