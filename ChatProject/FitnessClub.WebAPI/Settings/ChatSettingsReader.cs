namespace Chat.WebAPI.Settings
{
    public static class ChatSettingsReader
    {
        public static ChatSettings Read(IConfiguration configuration)
        {
            //здесь будет чтение настроек приложения из конфига
            return new ChatSettings();
        }
    }
}
