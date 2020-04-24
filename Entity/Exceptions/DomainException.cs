using System;
namespace Reserva.Entity.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message): base(message){
            
        }
    }
}