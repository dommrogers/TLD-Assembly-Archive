using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetStatCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetStatCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetStatCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetStatCountOptionsInternal), Member = "set_TargetUserId")]
	[CallerCount(Count = 0)]
	public void Set(GetStatCountOptions other)
	{
	}

	[Calls(Type = typeof(GetStatCountOptionsInternal), Member = "set_TargetUserId")]
	[CalledBy(Type = typeof(StatsInterface), Member = "GetStatsCount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
