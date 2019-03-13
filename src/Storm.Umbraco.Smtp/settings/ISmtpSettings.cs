namespace Storm.Umbraco.Smtp.Settings
{
    public interface ISmtpSettings
    {
        string Host { get; }
        int Port { get; }
        string Username { get; }
        string Password { get; }
        bool EnableSsl { get; }
    }
}