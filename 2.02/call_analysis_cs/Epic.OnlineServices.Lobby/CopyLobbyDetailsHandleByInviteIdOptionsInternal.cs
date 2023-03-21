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
		[CalledBy(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
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

	[CalledBy(Type = typeof(LobbyInterface), Member = "CopyLobbyDetailsHandleByInviteId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "set_InviteId")]
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
