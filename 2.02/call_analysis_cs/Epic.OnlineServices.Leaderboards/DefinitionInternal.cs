using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct DefinitionInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LeaderboardId;

	private IntPtr m_StatName;

	private LeaderboardAggregation m_Aggregation;

	private long m_StartTime;

	private long m_EndTime;

	public string LeaderboardId
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string StatName
	{
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public LeaderboardAggregation Aggregation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(LeaderboardAggregation);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LeaderboardId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StatName")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_EndTime")]
	public void Set(Definition other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefinitionInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
