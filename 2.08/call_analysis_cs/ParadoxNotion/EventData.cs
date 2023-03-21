using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion;

public class EventData
{
	private string _003Cname_003Ek__BackingField;

	public string name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CallerCount(Count = 279)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public object value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual object GetValue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 279)]
	public EventData(string name)
	{
	}
}
public class EventData<T> : EventData
{
	private T _003Cvalue_003Ek__BackingField;

	public new T value
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override object GetValue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public EventData(string name, T value)
		: base(null)
	{
	}
}
