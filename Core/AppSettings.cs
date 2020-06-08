using Core.Exceptions;
using System.ComponentModel;
using System.Configuration;

namespace Core
{
    public static class AppSettings
    {
        public static string BindingsValues => Get<string>(nameof(BindingsValues));

        private static T Get<T>(string key)
        {
            string setting = ConfigurationManager.AppSettings[key];
            if (setting == null)
            {
                throw new AppSettingsKeyMissingException(key);
            }
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            return (T)converter.ConvertFromInvariantString(setting);
        }
    }
}
