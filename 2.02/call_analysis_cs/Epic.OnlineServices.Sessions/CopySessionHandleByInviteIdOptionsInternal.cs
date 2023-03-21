using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopySessionHandleByInviteIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_InviteId;

	public string InviteId
	{
		[CalledBy(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
	public void Set(CopySessionHandleByInviteIdOptions other)
	{
	}

	[CalledBy(Type = typeof(SessionsInterface), Member = "CopySessionHandleByInviteId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
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
