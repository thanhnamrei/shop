using ChainOfResponsibility;

Console.WriteLine("Chain of responsibility patter demo");

IReceiver faxHandler, emailHandler;


emailHandler = new EmailErrorHandler(); // last handle
faxHandler = new FaxErrorHandler(emailHandler);

//IssueRaiser raiser = new IssueRaiser(faxHandler);



Message m1 = new Message("Fax is reaching late to the destination", MessagePriority.High);
Message m2 = new Message("Email is reaching late to the destination", MessagePriority.High);

//faxHandler.HandleMessage(m1);
faxHandler.HandleMessage(m2);
//raiser.RaiseMessage(m1);
//raiser.RaiseMessage(m2);