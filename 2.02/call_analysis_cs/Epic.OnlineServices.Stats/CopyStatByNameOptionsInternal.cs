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
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Name
	{
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyStatByNameOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[CalledBy(Type = typeof(StatsInterface), Member = "CopyStatByName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyStatByNameOptionsInternal), Member = "set_Name")]
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
