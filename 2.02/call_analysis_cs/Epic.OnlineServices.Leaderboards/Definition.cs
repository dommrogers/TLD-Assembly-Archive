using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class Definition : ISettable
{
	private string _003CLeaderboardId_003Ek__BackingField;

	private string _003CStatName_003Ek__BackingField;

	private LeaderboardAggregation _003CAggregation_003Ek__BackingField;

	private DateTimeOffset? _003CStartTime_003Ek__BackingField;

	private DateTimeOffset? _003CEndTime_003Ek__BackingField;

	public string LeaderboardId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string StatName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		set
		{
		}
	}

	public LeaderboardAggregation Aggregation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		get
		{
			return default(LeaderboardAggregation);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Definition), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_LeaderboardId")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "get_StatName")]
	internal void Set(DefinitionInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Definition), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Definition()
	{
	}
}
