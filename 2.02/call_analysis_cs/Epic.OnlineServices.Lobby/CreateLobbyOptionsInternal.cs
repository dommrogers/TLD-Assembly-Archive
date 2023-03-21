using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CreateLobbyOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private uint m_MaxLobbyMembers;

	private LobbyPermissionLevel m_PermissionLevel;

	private int m_PresenceEnabled;

	public ProductUserId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint MaxLobbyMembers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public LobbyPermissionLevel PermissionLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool PresenceEnabled
	{
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	public void Set(CreateLobbyOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "set_PresenceEnabled")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "CreateLobby")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
