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
		[CallerCount(Count = 113)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 269)]
		private set
		{
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
	[CallerCount(Count = 269)]
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
			return default(T);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
