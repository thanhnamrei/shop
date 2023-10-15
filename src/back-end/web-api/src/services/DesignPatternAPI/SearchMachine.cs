namespace DesignPatternAPI;

public abstract class SearchMachine
{
	protected int[] Values { get; }

	public int? IndexOf(int value) // template method for client call
	{
		if (Values.Length == 0) return null;

		return Find(value);
	}

	protected abstract int? Find(int value); // operator

	protected SearchMachine(params int[] values)
	{
		Values = values;
	}
}

public class LinearSearchMachine : SearchMachine
{
	public LinearSearchMachine(int[] values) : base(values)
	{
	}

	protected override int? Find(int value)
	{
		var index = 0;
		foreach (var item in Values)
		{
			if (item == value) return index;
			index++;
		}

		return null;
	}
}

public class BinarySearchMachine : SearchMachine
{
	public BinarySearchMachine(params int[] values) : base(values.OrderBy(x => x).ToArray())
	{
	}

	protected override int? Find(int value)
	{
		var index = Array.BinarySearch(Values, value);

		return index >= 0 ? index : null;
	}
}