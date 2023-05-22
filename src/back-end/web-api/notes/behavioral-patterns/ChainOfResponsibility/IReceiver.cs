namespace ChainOfResponsibility;

public interface IReceiver
{
    bool HandleMessage(Message message);
}

public class FaxErrorHandler : IReceiver
{
    private readonly IReceiver? _next;

    public FaxErrorHandler(IReceiver? next = null)
    {
        _next = next;
    }

    public bool HandleMessage(Message message)
    {
        if (message.Text.Contains("Fax"))
        {
            Console.WriteLine("FaxErrorHandler processed {0} priority issue: {1}", message.Priority, message.Text);
            return true;
        }

        _next?.HandleMessage(message);
        return false;

    }
}

public class EmailErrorHandler : IReceiver
{
    private readonly IReceiver? _next;

    public EmailErrorHandler(IReceiver? next = null)
    {
        _next = next;
    }

    public bool HandleMessage(Message message)
    {
        if (message.Text.Contains("Email"))
        {
            Console.WriteLine("EmailErrorHandler processed {0} priority issue: {1}", message.Priority, message.Text);
            return true;
        }

        _next?.HandleMessage(message);
        return false;
    }
}