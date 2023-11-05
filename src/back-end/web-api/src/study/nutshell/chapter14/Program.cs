bool _done = false;

//new Thread(Go).Start();
//Go();

ThreadStart action = () =>
{
	if (!_done)
	{
		_done = true;
		Console.WriteLine("Done");
	}
};
new Thread(action).Start();
action();

//void Go()
//{
//	if (!_done)
//	{
//		_done = true;
//		Console.WriteLine("Done");
//	}
//}