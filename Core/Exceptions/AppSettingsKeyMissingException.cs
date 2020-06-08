using System;

namespace Core.Exceptions
{
    public class AppSettingsKeyMissingException : ApplicationException
    {
        public AppSettingsKeyMissingException(string keyName) : base ($"AppSettings key is missing:{keyName}")
        {

        }
    }
}
