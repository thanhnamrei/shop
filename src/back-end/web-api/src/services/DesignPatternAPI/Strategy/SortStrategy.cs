using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAPI.Strategy;

public interface ISortStrategy
{
	IOrderedEnumerable<string> Sort(IEnumerable<string> input);
}

public class SortAscendingStrategy : ISortStrategy
{
	public IOrderedEnumerable<string> Sort(IEnumerable<string> input)
	{
		return input.OrderBy(x => x);
	}
}

public class SortDescendingStrategy : ISortStrategy
{
	public IOrderedEnumerable<string> Sort(IEnumerable<string> input)
	{
		return input.OrderByDescending(x => x);
	}
}

public class SortableCollection
{
	public ISortStrategy? SortStrategy { get; set; }
	public IEnumerable<string> Items { get; private set; }

	public SortableCollection(IEnumerable<string> items)
	{
		Items = items;
	}

	public void Sort()
	{
		if (SortStrategy is null)
		{
			throw new NullReferenceException(nameof(SortStrategy));
		}

		 Items = SortStrategy.Sort(Items);
	}
}