using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Mods;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyModInfoOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private ModEnumerationType m_Type;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyModInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyModInfoOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public ModEnumerationType Type
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyModInfoOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyModInfoOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyModInfoOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(ModsInterface), Member = "CopyModInfo")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
