using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct UpdateLobbyModificationOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_LobbyId;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string LobbyId
	{
		[CalledBy(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "set_LobbyId")]
	public void Set(UpdateLobbyModificationOptions other)
	{
	}

	[Calls(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "set_LobbyId")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "set_LocalUserId")]
	[CalledBy(Type = typeof(LobbyInterface), Member = "UpdateLobbyModification")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void Dispose()
	{
	}
}
