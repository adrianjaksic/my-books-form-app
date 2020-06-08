using System;

namespace Core.Exceptions
{
    public class WrongDataException : ApplicationException
    {
        public WrongDataException(string dataName) : base ($"Imported data for {dataName} has wrong format.")
        {

        }

        public WrongDataException(string dataName, Exception innerException) : base($"Imported data for {dataName} has wrong format.", innerException)
        {

        }
    }
}
