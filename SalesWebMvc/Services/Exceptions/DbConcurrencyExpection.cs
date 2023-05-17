using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyExpection : ApplicationException
    {
        public DbConcurrencyExpection(string message) : base(message) { }
    }
}
