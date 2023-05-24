using System;
using ApiCorreo;

namespace Library

{
    public class Correo : IMessage
    {
        public void Send(Message message)
        {
            var correo = new CorreoApi();
            correo.Send(message.To , message.Text);
        }

        public Message GetMessage(Contact email, string text)
        {
            return new CorreoMessage(email, text);
        }
    }
}