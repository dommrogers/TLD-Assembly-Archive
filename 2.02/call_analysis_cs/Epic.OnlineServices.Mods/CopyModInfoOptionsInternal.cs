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
		[CalledBy(Type = typeof(CopyModInfoOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyModInfoOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyModInfoOptionsInternal), Member = "set_LocalUserId")]
	public void Set(CopyModInfoOptions other)
	{
	}

	[CalledBy(Type = typeof(ModsInterface), Member = "CopyModInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyModInfoOptionsInternal), Member = "set_LocalUserId")]
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
