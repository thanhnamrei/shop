using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAPI;

public record Message(string Name, string? Payload);

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
		if (message.Name == "AlarmTriggered")
		{
			//
		}
		else if (_next != null)
		{
			_next.Handle(message);
		}
	}
}

public class AlarmPausedHandler : IMessageHandler
{
	private readonly IMessageHandler? _next;

	public AlarmPausedHandler(IMessageHandler? next = null)
	{
		_next = next;
	}

	public void Handle(Message message)
	{
		if (message.Name == "AlarmPaused")
		{
			// TODO
		}
		else if (_next != null)
		{
			_next.Handle(message);
		}
	}
}

public class AlarmStoppedHandler : IMessageHandler
{
	private readonly IMessageHandler? _next;

	public AlarmStoppedHandler(IMessageHandler? next = null)
	{
		_next = next;
	}

	public void Handle(Message message)
	{
		if (message.Name == "AlarmStopped")
		{
		}
		else if (_next != null)
		{
			_next.Handle(message);
		}
	}
}

public abstract class MessageHandlerBase : IMessageHandler
{
	private readonly IMessageHandler? _next;

	protected MessageHandlerBase(IMessageHandler? next)
	{
		_next = next;
	}

	public void Handle(Message message)
	{
		if (CanHandle(message))
		{
			Process(message);
		}
		else if (HasNext())
		{
			_next.Handle(message);
		}
	}

	protected virtual bool CanHandle(Message message)
	{
		return message.Name == HandledMessageName;
	}

	protected abstract string HandledMessageName { get; }

	protected abstract void Process(Message message);

	[MemberNotNullWhen(true, nameof(_next))]
	private bool HasNext() => _next != null;
}