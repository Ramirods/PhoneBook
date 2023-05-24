namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message, Contact contact);
         public Message GetMessage(Contact contact, string text);
    }
}