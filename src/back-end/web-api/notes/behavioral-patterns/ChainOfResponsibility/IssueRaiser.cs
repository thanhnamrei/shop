namespace ChainOfResponsibility;

public class IssueRaiser
{
    public IReceiver FirstReceiver;

    public IssueRaiser(IReceiver firstReceiver)
    {
        FirstReceiver = firstReceiver;
    }

    public void RaiseMessage(Message message)
    {
        FirstReceiver.HandleMessage(message);
    }
}