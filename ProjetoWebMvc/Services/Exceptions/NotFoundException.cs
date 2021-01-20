using System;

namespace ProjetoWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(String message) : base(message)
        {
        }
    }
}
