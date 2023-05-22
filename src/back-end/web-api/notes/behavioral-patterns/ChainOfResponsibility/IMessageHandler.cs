namespace ChainOfResponsibility;
public interface IMessageHandler
{
    void Handle(Message message);
}


public class AlarmTriggeredHandler : IMessageHandler
{
    private readonly IMessageHandler? _next;

    public AlarmTriggeredHandler(IMessageHandler? next = null)
    {
        _next = next;
    }


    public void Handle(Message message)
    {
        //if (message.Name == "AlarmTriggered")
        //{
        //    //
        //}
        //else if (_next != null)
        //{
        //    _next.Handle(message);
        //}
    }
}