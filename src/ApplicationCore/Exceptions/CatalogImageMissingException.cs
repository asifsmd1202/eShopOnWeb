using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Exceptions
{
    class CatalogImageMissingException : Exception
    {
        public CatalogImageMissingException(string message, Exception innerException = null) 
            : base(message, innerException)
        {

        }

        public CatalogImageMissingException(Exception innerException)
            : base("No catalog image found for the provide id.", innerException: innerException)
        {
            
        }

        public CatalogImageMissingException() : base()
        {

        }

        public CatalogImageMissingException(string message) : base(message)
        {

        }
    }
}
