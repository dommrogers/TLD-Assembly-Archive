using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyLobbyDetailsHandleByInviteIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_InviteId;

	public string InviteId
	{
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
	public void Set(CopyLobbyDetailsHandleByInviteIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "CopyLobbyDetailsHandleByInviteId")]
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
