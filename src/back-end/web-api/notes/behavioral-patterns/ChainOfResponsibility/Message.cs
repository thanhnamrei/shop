namespace ChainOfResponsibility;

public class Message
{
    public string Text { get; set; }
    public MessagePriority Priority { get; set; }

    public Message(string msg, MessagePriority priority)
    {
        Text = msg;
        Priority = priority;
    }
}