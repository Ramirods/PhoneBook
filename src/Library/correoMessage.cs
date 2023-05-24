using System;
namespace Library
{
    public class CorreoMessage : Message
    {
        public CorreoMessage (Contact contact, string text) : base (null, contact.Email, text)
        {
            
        }
    }
}