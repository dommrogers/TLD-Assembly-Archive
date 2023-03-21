using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 56)]
internal struct QueryStatsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private long m_StartTime;

	private long m_EndTime;

	private IntPtr m_StatNames;

	private uint m_StatNamesCount;

	private IntPtr m_TargetUserId;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] StatNames
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_StatNames")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_EndTime")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 1)]
	public void Set(QueryStatsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
	[CalledBy(Type = typeof(StatsInterface), Member = "QueryStats")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
