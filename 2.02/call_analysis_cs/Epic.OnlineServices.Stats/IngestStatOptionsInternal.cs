using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct IngestStatOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_Stats;

	private uint m_StatsCount;

	private IntPtr m_TargetUserId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IngestData[] Stats
	{
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(IngestStatOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_Stats")]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_TargetUserId")]
	public void Set(IngestStatOptions other)
	{
	}

	[CalledBy(Type = typeof(StatsInterface), Member = "IngestStat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_Stats")]
	[Calls(Type = typeof(IngestStatOptionsInternal), Member = "set_TargetUserId")]
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
