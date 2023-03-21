using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyStatByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private uint m_StatIndex;

	public ProductUserId TargetUserId
	{
		[CalledBy(Type = typeof(CopyStatByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyStatByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint StatIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyStatByIndexOptionsInternal), Member = "set_TargetUserId")]
	public void Set(CopyStatByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(StatsInterface), Member = "CopyStatByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyStatByIndexOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
