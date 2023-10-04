using System;

namespace dotnetapp.Exceptions
{
    public class SlotBookingException : Exception
    {
        //write class here...
        protected string CustomErrorMessage {get;set;}
    }
}