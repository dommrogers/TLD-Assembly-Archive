using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct JoinLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LobbyDetailsHandle;

	private IntPtr m_LocalUserId;

	private int m_PresenceEnabled;

	public LobbyDetails LobbyDetailsHandle
	{
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LobbyDetailsHandle")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	public void Set(JoinLobbyOptions other)
	{
	}

	[CalledBy(Type = typeof(LobbyInterface), Member = "JoinLobby")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LobbyDetailsHandle")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "set_PresenceEnabled")]
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
