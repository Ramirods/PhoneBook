using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Nito.AsyncEx;

namespace ApiCorreo
{
    public class CorreoApi
    {


        public string Send(string to, string text)
        {


            var message = MessageResource.Create(
                body: text,
                from: new Twilio.Types.PhoneNumber("paulaadjemian2004@gmail.com"),
                to: new Twilio.Types.PhoneNumber($"{to}")
            );

            return message.Sid;
        }
    }
}