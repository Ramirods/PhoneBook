using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        //Conocer el dueño
        public Contact Owner { get; }

    
        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        //Agregar contactos a la lista
        public void Add(Contact person)
        {
            this.persons.Add(person);
        }

        //Quitar contactos de la lista
        public void Remove(Contact person)
        {
            this.persons.Remove(person);
        }

        //Enviar un mensaje a contactos dados sus nombres a través de un canal
        public void Send(string[] names, Message message, IMessageChannel chanel)
        {
            List<Contact> contacts = this.Search(names);

            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Sending message to {contact.Name}...");
                chanel.Send(message, contact);
            }
        }
    }
}