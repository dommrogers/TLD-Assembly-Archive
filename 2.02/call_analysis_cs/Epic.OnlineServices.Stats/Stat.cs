using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

public class Stat : ISettable
{
	private string _003CName_003Ek__BackingField;

	private DateTimeOffset? _003CStartTime_003Ek__BackingField;

	private DateTimeOffset? _003CEndTime_003Ek__BackingField;

	private int _003CValue_003Ek__BackingField;

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int Value
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StatInternal), Member = "get_Name")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CalledBy(Type = typeof(Stat), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(StatInternal? other)
	{
	}

	[Calls(Type = typeof(Stat), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Stat()
	{
	}
}
