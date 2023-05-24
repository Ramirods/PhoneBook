using System;
using System.Collections.Generic;
using Library;
using WhatsAppApiUCU;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño

             Contact Person1= new Contact("Paula","598091497408","paula@gmail.com");

            // Crear la lista de contactos
            
            Phonebook emisor = new Phonebook(Person1);

            // Agregar contactos a la lista
            
            Contact Person2 = new Contact("Pablo","598092465792","pablo@gmail.com");
            emisor.Add(Person2);

            // Enviar un correo a algunos contactos

            
            emisor.Send("Paula",new Correo(),"hola");

            // Enviar un WhatsApp a algunos contactos
            List<string> list = new List<string>{("a")};
            emisor.Send("Pablo",new WhatsApp(),"hola");
            // Enviar un SMS a algunos contactos
        }
    }
}

 
            
            
