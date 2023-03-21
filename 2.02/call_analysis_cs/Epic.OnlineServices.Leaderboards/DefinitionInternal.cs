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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string StatName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(Definition), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(DefinitionInternal), Member = "set_EndTime")]
	[CalledBy(Type = typeof(DefinitionInternal), Member = "Set")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_LeaderboardId")]
	[Calls(Type = typeof(DefinitionInternal), Member = "set_StatName")]
	[CallerCount(Count = 1)]
	public void Set(Definition other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DefinitionInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
