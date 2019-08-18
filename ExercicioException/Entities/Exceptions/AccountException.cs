using System;

namespace ExercicioExcption.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
