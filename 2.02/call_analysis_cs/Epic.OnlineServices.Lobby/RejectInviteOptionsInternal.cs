using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct RejectInviteOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_InviteId;

	private IntPtr m_LocalUserId;

	public string InviteId
	{
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	public void Set(RejectInviteOptions other)
	{
	}

	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "set_InviteId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "RejectInvite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
