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
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? StartTime
	{
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public DateTimeOffset? EndTime
	{
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] StatNames
	{
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_StartTime")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_EndTime")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_StatNames")]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "set_TargetUserId")]
	public void Set(QueryStatsOptions other)
	{
	}

	[CalledBy(Type = typeof(StatsInterface), Member = "QueryStats")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryStatsOptionsInternal), Member = "Set")]
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
