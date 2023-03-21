using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Stats;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyStatByNameOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_TargetUserId;

	private IntPtr m_Name;

	public ProductUserId TargetUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string Name
	{
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_Name")]
	public void Set(CopyStatByNameOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_Name")]
	[CalledBy(Type = typeof(StatsInterface), Member = "CopyStatByName")]
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
