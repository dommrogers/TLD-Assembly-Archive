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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "Set")]
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
	[Calls(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
