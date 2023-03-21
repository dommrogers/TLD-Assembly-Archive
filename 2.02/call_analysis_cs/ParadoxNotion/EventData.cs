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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		private set
		{
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 103)]
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
		[CallerCount(Count = 35)]
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
	[CallsUnknownMethods(Count = 2)]
	protected override object GetValue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public EventData(string name, T value)
		: base(null)
	{
	}
}
