using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

public class QueryStatsOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private DateTimeOffset? _003CStartTime_003Ek__BackingField;

	private DateTimeOffset? _003CEndTime_003Ek__BackingField;

	private string[] _003CStatNames_003Ek__BackingField;

	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public string[] StatNames
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryStatsOptions()
	{
	}
}
